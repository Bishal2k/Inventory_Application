using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class ProfileUpdateDto:ProfileCreateDto
    {
        public ProfileUpdateDto(long id, string name, string contact, string address, string companyName):
            base(name,contact,address,companyName)
        {
            Id = id;
        }
        public long Id { get; set; }
    }
}
