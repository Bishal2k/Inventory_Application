using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class ProfileCreateViewModel
    {
        public virtual string Name { get; set; }
        public virtual string Contact { get; set; }
        public virtual string Address { get; set; }
        public virtual string CompanyName { get; set; }
    }
}
