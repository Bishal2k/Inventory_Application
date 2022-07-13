using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class AccountIndexViewModel
    {
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        
    }
}
