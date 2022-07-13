using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class Profile
    {
        protected Profile()
        {

        }
        public Profile(string name, string contact, string address,string companyName)
        {
            Name = name;
            Contact = contact;
            Address = address;
            CompanyName = companyName;
        }
        public virtual long Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Contact { get; set; }
        public virtual string  Address { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual void Update(string name, string contact, string address, string companyName)
        {
            Name = name;
            Contact = contact;
            Address = address;
            CompanyName = companyName;
        }
    }
}
