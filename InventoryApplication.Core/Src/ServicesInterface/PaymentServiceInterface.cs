using InventoryApplication.Dto;
using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Services.ServicesInterface
{
    public interface PaymentServiceInterface
    {
        public Task InsertAsync(PaymentInsertDto dto);
        public Task UpdateAsync(PaymentUpdateDto dto);
    }
}
