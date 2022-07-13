using Crystal.Sms.Core.Helper;
using InventoryApplication.Dto;
using InventoryApplication.Models.Entity;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace InventoryApplication.Services
{
    public class BillService : BillServiceInterface
    {
        readonly BillRepositoryInterface _billRepo;
        readonly ProductRepositoryInterface _productRepo;
        readonly AccountRepositoryInterface _accountRepo;
        public BillService(BillRepositoryInterface billRepo, ProductRepositoryInterface productRepo, AccountRepositoryInterface accountRepo)
        {
            _billRepo = billRepo;
            _productRepo = productRepo;
            _accountRepo = accountRepo;
        }
        public async Task InsertAsync(BillInsertDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var bill = new Bill();
            bill.Profile = dto.Profile;
            bill.ProfileId = dto.Profile.Id;
            bill.BillDate = dto.BillDate;
            foreach (var item in dto.BillItems)
            {
                var product = await _productRepo.GetByIdAsync(item.ProductId);
                bill.AddBillItem(product, item.Quantity, item.Rate);
                var amountToBeAddedInAccount = Convert.ToDecimal(item.Quantity * item.Rate);
                await SubtractStock(product, (int)item.Quantity);
                await AddAmountToProfile(dto.Profile.Id, amountToBeAddedInAccount);
            }
            
            await _billRepo.InsertAsync(bill);
            scope.Complete();
        }
        private async Task SubtractStock(Product product, int quantityToSubtract)
        {
            product.Quantity -= quantityToSubtract;
            await _productRepo.UpdateAsync(product);
        }
        private async Task AddAmountToProfile(long profileId, decimal amountToBeAddedInProfile)
        {
            var account = await _accountRepo.GetByProfileIdAsync(profileId);
            account.AmountReceiveable += amountToBeAddedInProfile;
            await _accountRepo.UpdateAsync(account);
        }
        public async Task UpdateBillOnlyAsync(BillUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var bill = await _billRepo.GetById(dto.Id);
            decimal previouslyAddedAmount = 0;
            foreach (var item in bill.BillItems)
            {
                previouslyAddedAmount = Convert.ToDecimal(item.Quantity * item.Rate);
            }
            if (bill.ProfileId != dto.ProfileId)
            {
                await SubtractAmountFromAccountWhileUpdate(bill.ProfileId, previouslyAddedAmount);
                await AddAmountToAccountWhileUpdate(dto.ProfileId, previouslyAddedAmount);
                bill.Profile = dto.Profile;
                bill.ProfileId = dto.Profile.Id;
                bill.BillDate = dto.BillDate;
                await _billRepo.UpdateAsync(bill);
                scope.Complete();
                return;
            }
            bill.Profile = dto.Profile;
            bill.ProfileId = dto.Profile.Id;
            bill.BillDate = dto.BillDate;
            await _billRepo.UpdateAsync(bill);
            scope.Complete();
        }
        private async Task SubtractAmountFromAccountWhileUpdate(long profileId,decimal amountToBeSubtracted)
        {
            var account = await _accountRepo.GetByProfileIdAsync(profileId);
            account.AmountReceiveable -= amountToBeSubtracted;
            await _accountRepo.UpdateAsync(account);
        }
        private async Task AddAmountToAccountWhileUpdate(long profileId, decimal amountToBeAdded)
        {
            var account = await _accountRepo.GetByProfileIdAsync(profileId);
            account.AmountReceiveable += amountToBeAdded;
            await _accountRepo.UpdateAsync(account);
        }

        public async Task UpdateBillItems(BillItemUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            decimal previouslyAddedAmount = 0;
            decimal actualUpdatedAmount = 0;
            uint initialQuantityofProduct = dto.Bill.BillItems.AsQueryable().Where(x => x.Id == dto.BillItemId).SingleOrDefault().Quantity;
            long productId = dto.Bill.BillItems.AsQueryable().Where(x => x.Id == dto.BillItemId).SingleOrDefault().ProductId;
            int quantityToBeUpdated = (int)initialQuantityofProduct - (int)dto.Quantity;
            foreach (var item in dto.Bill.BillItems)
            {
                previouslyAddedAmount += Convert.ToDecimal(item.Quantity * item.Rate);
            }
            dto.Bill.UpdateBillItem(dto.BillItemId, dto.Product, dto.Quantity, dto.Rate);
            foreach (var item in dto.Bill.BillItems)
            {
                actualUpdatedAmount += Convert.ToDecimal(item.Quantity * item.Rate);
            }
            decimal amountToBeUpdated = actualUpdatedAmount - previouslyAddedAmount;
            await AddAmountToAccountWhileUpdate(dto.Bill.ProfileId, amountToBeUpdated);
            await UpdateProductQuantity(productId, quantityToBeUpdated);
            scope.Complete();
        }
        private async Task UpdateProductQuantity(long productId, int quantityToBeUpdated)
        {
            var product = await _productRepo.GetByIdAsync(productId);
            product.Quantity += quantityToBeUpdated;
            await _productRepo.UpdateAsync(product);
        }
    }
}
