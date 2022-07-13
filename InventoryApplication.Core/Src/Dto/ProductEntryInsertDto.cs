using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class ProductEntryInsertDto
    {
        public ProductEntryInsertDto(Product product, Profile profile, int quantity, double rate, string billNo,
            string vechileNo, string entryDate)
        {
            Product = product;
            Profile = profile;
            Quantity = quantity;
            Rate = rate;
            BillNo = billNo;
            VechileNo = vechileNo;
            EntryDate = entryDate;
        }
        public Product Product { get; set; }
        public Profile Profile { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public string BillNo { get; set; }
        public string VechileNo { get; set; }
        public string EntryDate { get; set; }
    }
}
