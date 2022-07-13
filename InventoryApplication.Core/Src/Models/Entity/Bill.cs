using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class Bill
    {
        public Bill()
        {
            TimeStamp = DateTime.Now;
        }
        
        public virtual long  Id { get; protected set; }
        public virtual Profile Profile { get;  set; }
        public virtual long ProfileId { get;  set; }
        public virtual string BillDate { get; set; }
        public virtual DateTime TimeStamp { get; set; }
        public  virtual ICollection<BillItem> BillItems { get; set; } = new List<BillItem>();

        public virtual void AddBillItem(Product item, uint quantity, double rate)
        {
            var billItem = new BillItem();
            billItem.Bill = this;
            billItem.Item = item;
            billItem.ProductId = item.Id;
            billItem.Quantity = quantity;
            billItem.Rate = rate;
            billItem.BillId = this.Id;
            BillItems.Add(billItem);
        }
        public virtual void UpdateBillItem(long billItemId, Product item, uint quantity, double rate)
        {
            BillItems.AsQueryable().Where(x => x.Id == billItemId).SingleOrDefault().Item = item;
            BillItems.AsQueryable().Where(x => x.Id == billItemId).SingleOrDefault().ProductId = item.Id;
            BillItems.AsQueryable().Where(x => x.Id == billItemId).SingleOrDefault().Quantity = quantity;
            BillItems.AsQueryable().Where(x => x.Id == billItemId).SingleOrDefault().Rate = rate;
        }
        
    }
    
}
