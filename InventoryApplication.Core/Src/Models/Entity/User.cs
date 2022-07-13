using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
    }
}
