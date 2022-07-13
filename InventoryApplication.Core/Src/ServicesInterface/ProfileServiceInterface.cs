using InventoryApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Services.ServicesInterface
{
    public interface ProfileServiceInterface
    {
        public Task CreateAsync(ProfileCreateDto dto);
        public Task UpdateAsync(ProfileUpdateDto dto);
    }
}
