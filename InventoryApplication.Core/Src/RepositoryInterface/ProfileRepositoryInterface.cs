using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface ProfileRepositoryInterface
    {
        public Task InsertAsync(Profile profile);
        public Task<List<Profile>> GetAllAsync();
        public Task<Profile> GetByIdAsync(long id);
        public Task UpdateAsync(Profile profile);
    }
}
