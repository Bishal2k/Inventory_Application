using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class BillItem
    {
        public virtual long Id { get; set; }
        public virtual long BillId { get; set; }
        public virtual Bill Bill { get; set; }
        
        public virtual long ProductId { get; set; }
        public virtual Product Item { get; set; }
        public virtual uint Quantity { get; set; }
        public virtual double Rate { get; set; }
        //public virtual decimal Total { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
