using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface BillRepositoryInterface
    {
        public Task<Bill> GetById(long id);
        public Task InsertAsync(Bill bill);
        public Task UpdateAsync(Bill bill);
        public Task<Bill> GetLatestBillAsync();
        public Task<List<Bill>> GetAllAsync();


    }
}
