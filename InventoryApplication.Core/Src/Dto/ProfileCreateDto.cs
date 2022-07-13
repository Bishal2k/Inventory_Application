using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class ProfileCreateDto
    {
        public ProfileCreateDto(string name, string contact, string address, string companyName)
        {
            Name = name;
            Contact = contact;
            Address = address;
            CompanyName = companyName;
        }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string  Address { get; set; }
        public string CompanyName { get; set; }
    }
}
