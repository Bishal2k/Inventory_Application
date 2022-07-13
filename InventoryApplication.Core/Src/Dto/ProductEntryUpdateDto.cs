using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class ProductEntryUpdateDto:ProductEntryInsertDto
    {
        public ProductEntryUpdateDto(long id,Product product, Profile profile, int quantity, double rate, string billNo,
            string vechileNo, string entryDate) :base(product,profile,quantity,rate,billNo,vechileNo,entryDate)
        {
            Id = id;
        }
        public long Id { get; set; }
    }
}
