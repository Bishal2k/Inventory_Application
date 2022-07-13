using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface ProductEntryRepositoryInterface
    {
        public Task InsertAsync(ProductEntryData productEntry);
        
        public Task UpdateAsync(ProductEntryData productEntry);
        public Task<ProductEntryData> GetByIdAsync(long id );
        public Task<List<ProductEntryData>> GetAllAsync();
        
    }
}
