using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class ProductEntryCreateViewModel
    {
        public IList<Profile> Profiles { get; set; } = new List<Profile>();
       
        public long  ProductId{ get; set; }
        public long ProfileId { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public string BillNo { get; set; }
        public string VechileNo { get; set; }
        public string EntryDate { get; set; }
    }
}
