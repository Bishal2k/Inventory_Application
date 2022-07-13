using InventoryApplication.Dto;
using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Services.ServicesInterface
{
    public interface BillServiceInterface
    {
        public Task InsertAsync(BillInsertDto dto);
        public Task UpdateBillOnlyAsync(BillUpdateDto dto);
        public Task UpdateBillItems(BillItemUpdateDto dto);
    }
}
