using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class BillGenerateViewModel
    {

        public long BillNo { get; set; }
        public long ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string BillDate { get; set; }
        public virtual ICollection<BillItem> BillItems { get; set; } = new List<BillItem>();
    }
}
