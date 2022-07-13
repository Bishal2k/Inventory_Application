using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class ProductEntryData
    {
        protected ProductEntryData()
        {

        }
         public ProductEntryData(Product product, Profile profile, int quantity, double rate, string billNo,
             string vechileNo,string entryDate)
        {
            Profile = profile;
            ProfileId = profile.Id;
            Product = product;
            ProductId = product.Id;
            Quantity = quantity;
            Rate = rate;
            BillNo = billNo;
            VechileNo = vechileNo;
            EntryDate = entryDate;
        }
        public virtual long Id { get; protected set; }
        public virtual long ProductId { get; set; }
        public virtual long ProfileId { get; set; }
        public virtual Product Product { get; set; }
        public virtual  Profile Profile { get; set; }
        public virtual int Quantity { get; set; }
        public virtual double Rate { get; set; }
        public virtual string BillNo { get; set; }
        public virtual string VechileNo { get; set; }
        public virtual string EntryDate { get; set; }
        public virtual void Update(Product product, Profile profile, int quantity, double rate, string billNo,
             string vechileNo, string entryDate)
        {
            Profile = profile;
            ProfileId = profile.Id;
            Product = product;
            ProductId = product.Id;
            Quantity = quantity;
            Rate = rate;
            BillNo = billNo;
            VechileNo = vechileNo;
            EntryDate = entryDate;
        }
    }
}
