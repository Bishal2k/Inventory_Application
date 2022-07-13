using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class ProductEntryIndexViewModel
    {
        public ICollection<ProductEntryData> ProductEntryDatas { get; set; } = new List<ProductEntryData>();

    }
}
