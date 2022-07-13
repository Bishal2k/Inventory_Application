using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class PaymentIndexViewModel
    {
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
