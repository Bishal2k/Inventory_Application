using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Repository.RepositoryInterface
{
    public interface PaymentRepositoryInterface
    {
        public Task InsertAsync(Payment payment);
        public Task UpdateAsync(Payment payment);
        public Task<Payment> GetPaymentByIdAsync(long id);
        public Task<List<Payment>> GetAllPaymentsAsync();

    }
}
