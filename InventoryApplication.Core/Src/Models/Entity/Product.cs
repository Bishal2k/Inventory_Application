using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class Product
    {
        protected  Product()
        {

        }
        public Product(string name, double weight)
        {
            Name = name;
            Weight = weight;
            Quantity = 0;
        }
        public virtual long Id { get; protected set; }
        public virtual string Name { get; set; }
        public  virtual int Quantity { get; set; }
        public virtual double Weight { get; set; }
        public virtual void  Update(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }
    }
}
