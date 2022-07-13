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
    public class AccountService : AccountServiceInterface
    {
        readonly AccountRepositoryInterface _accountRepo;
        readonly ProfileRepositoryInterface _profileRepo;
        public AccountService(AccountRepositoryInterface accountRepo, ProfileRepositoryInterface profileRepo)
        {
            _accountRepo = accountRepo;
            _profileRepo = profileRepo;
        }
        public async Task InsertAsync(AccountCreateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var account = new Account();
            account.Profile = dto.Profile;
            account.ProfileId = dto.Profile.Id;
            await _accountRepo.InsertAsync(account);
            scope.Complete();
        }

        public async Task UpdateAsync(AccountUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var account = await _accountRepo.GetByIdAsync(dto.Id);
            account.AmountPayable = dto.AmountPayable;
            account.AmountReceiveable = dto.AmountReceiveable;
            await _accountRepo.UpdateAsync(account);
            scope.Complete();
        }
        public async Task CreateAccountAsync()
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var profileList = await _profileRepo.GetAllAsync();
            var accountList = await _accountRepo.GetAllAsync();
            foreach (var item in profileList)
            {
                if (!accountList.Any())
                {
                    var account = new Account();
                    account.Profile = item;
                    account.ProfileId = item.Id;
                    await _accountRepo.InsertAsync(account);
                    continue;
                }
               
                if (accountList.Any(a => a.Profile.Id == item.Id))
                {
                    continue;
                }
                var account2 = new Account();
                account2.Profile = item;
                account2.ProfileId = item.Id;
                await _accountRepo.InsertAsync(account2);
            }
            scope.Complete();
        }
    }
}
