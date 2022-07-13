using InventoryApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Services.ServicesInterface
{
    public interface ProductEntryServiceInterface
    {
        public Task InsertAsync(ProductEntryInsertDto dto);
        public Task UpdateAsync(ProductEntryUpdateDto dto);
    }
}
