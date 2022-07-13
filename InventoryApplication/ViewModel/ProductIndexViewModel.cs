using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class ProductIndexViewModel
    {
        public ICollection<Product> Products { get; set; }
        public ProductIndexViewModel()
        {
            Products = new List<Product>();
        }
    }
}
