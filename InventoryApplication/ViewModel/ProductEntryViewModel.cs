using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class ProductEntryViewModel
    {
        public IList<Profile> Profile { get; set; } = new List<Profile>();
    }
}
