using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface ProductRepositoryInterface
    {
        public Task InsertAsync(Product product);
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(long id);
        public Task UpdateAsync(Product product);
    }
}
