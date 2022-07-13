using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class BillItemUpdateDto
    {
        public Bill Bill { get; set; }
        public long BillItemId { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; }
        public double Rate { get; set; }
    }
}
