using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class BillCreateViewModel
    {
        public Profile Profile { get; set; }
        public long ProfileId { get; set; }
        public string BillDate { get; set; }
        public virtual ICollection<Product> ProductList { get; set; } = new List<Product>();
        public uint Quantity { get; set; }
        public double Rate { get; set; }
        public Product Item { get; set; }
        public long ProductId { get; set; }
        public virtual ICollection<BillItem> BillItems { get; set; } = new List<BillItem>();
        public long BillId { get; set; }
        public long BillItemId { get; set; }


    }
}
