using InventoryApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Services.ServicesInterface
{
    public interface AccountServiceInterface
    {
        public Task InsertAsync(AccountCreateDto dto);
        public Task UpdateAsync(AccountUpdateDto dto);
        public Task CreateAccountAsync();
    }
}
