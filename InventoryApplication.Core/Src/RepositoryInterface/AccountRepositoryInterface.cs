using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface AccountRepositoryInterface
    {
        public Task<List<Account>> GetAllAsync();
        public Task<Account> GetByIdAsync(long id);
        public Task InsertAsync(Account account);
        public Task UpdateAsync(Account account);
        public Task<Account> GetByProfileIdAsync(long id);

    }
}
