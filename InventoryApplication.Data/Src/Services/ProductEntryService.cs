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
    public class ProductEntryService : ProductEntryServiceInterface
    {
        readonly ProductEntryRepositoryInterface _productEntryRepo;
        readonly ProductRepositoryInterface _productRepo;
        readonly AccountRepositoryInterface _accountRepo;
        public ProductEntryService(ProductEntryRepositoryInterface productEntryRepo, ProductRepositoryInterface productRepo, AccountRepositoryInterface accountRepo)
        {
            _productEntryRepo = productEntryRepo;
            _productRepo = productRepo;
            _accountRepo = accountRepo;
        }
        public async  Task InsertAsync(ProductEntryInsertDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var productEntryData = new ProductEntryData(dto.Product,dto.Profile,dto.Quantity,dto.Rate,dto.BillNo,dto.VechileNo,dto.EntryDate);
            await  _productEntryRepo.InsertAsync(productEntryData);
            dto.Product.Quantity = dto.Product.Quantity + dto.Quantity;
            decimal totalSum = Convert.ToDecimal(dto.Rate * dto.Quantity) ;
            await _productRepo.UpdateAsync(dto.Product);
            await UpdateAmountPayableWhileInsert(dto.Profile.Id, totalSum);
            scope.Complete();
        }

        public async Task UpdateAsync(ProductEntryUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            int quantityToAdd;
            int quantityToSubtract;
            var productEntryData = await _productEntryRepo.GetByIdAsync(dto.Id);
            decimal previouseAmountPayable = Convert.ToDecimal(productEntryData.Rate * productEntryData.Quantity);
            int unUpdatedQuantity = productEntryData.Quantity;
            if (dto.Quantity > unUpdatedQuantity)
            {
                quantityToAdd = dto.Quantity - unUpdatedQuantity;

                await AddStock(dto.Product.Id, quantityToAdd);
            }
            else
            {
                quantityToSubtract = unUpdatedQuantity - dto.Quantity;
                await SubtractStock(dto.Product.Id, quantityToSubtract);
            }
            productEntryData.Update(dto.Product, dto.Profile, dto.Quantity, dto.Rate, dto.BillNo, dto.VechileNo, dto.EntryDate);
            decimal totalSum = Convert.ToDecimal(dto.Rate * dto.Quantity);
            await _productEntryRepo.UpdateAsync(productEntryData);
            await UpdateAmountPayableWhileUpdate(dto.Profile.Id, previouseAmountPayable, totalSum);
            scope.Complete();
            
        }
        private async Task AddStock(long productId, int quantityToAdd)
        {
            
            var product = await _productRepo.GetByIdAsync(productId);
            product.Quantity += quantityToAdd;      
            await _productRepo.UpdateAsync(product);
            
        }
        private async Task SubtractStock(long productId, int quantityToSubtract)
        {
            var product = await _productRepo.GetByIdAsync(productId);
            product.Quantity -= quantityToSubtract;
            await _productRepo.UpdateAsync(product);
        }
        private async Task UpdateAmountPayableWhileInsert(long profileId, decimal amountToBeUpdated)
        {
            var account = await _accountRepo.GetByProfileIdAsync(profileId);
            account.AmountPayable = amountToBeUpdated;
            await _accountRepo.UpdateAsync(account);
        }
        private async Task UpdateAmountPayableWhileUpdate(long profileId, decimal previouslyAddedAmount, decimal amountToBeUpdated)
        {
            var account = await _accountRepo.GetByProfileIdAsync(profileId);
            account.AmountPayable -= previouslyAddedAmount;
            account.AmountPayable += amountToBeUpdated;
            await _accountRepo.UpdateAsync(account);
        }
    }


}
