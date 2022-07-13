using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class ProfileIndexViewModel
    {
        public ICollection<Profile> Profiles { get; set; }
        public ProfileIndexViewModel()
        {
            Profiles = new List<Profile>();
        }
    }
}
