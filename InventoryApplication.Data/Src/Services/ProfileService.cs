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
    public class ProfileService : ProfileServiceInterface
    {
        readonly ProfileRepositoryInterface _profileRepo;
        
        public ProfileService(ProfileRepositoryInterface profileRepo)
        {
            _profileRepo = profileRepo;
            
        }
        public async Task CreateAsync(ProfileCreateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var profile = new Profile(dto.Name,dto.Contact,dto.Address,dto.CompanyName);
            await _profileRepo.InsertAsync(profile);
            scope.Complete();
        }

        public async Task UpdateAsync(ProfileUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var profile = await _profileRepo.GetByIdAsync(dto.Id);
            profile.Update(dto.Name, dto.Contact, dto.Address, dto.CompanyName);
            await _profileRepo.UpdateAsync(profile);
            scope.Complete();
        }
    }
}
