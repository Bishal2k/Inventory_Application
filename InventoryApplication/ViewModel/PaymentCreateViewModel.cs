using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.ViewModel
{
    public class PaymentCreateViewModel
    {
        public long AccountId { get; set; }
        public IReadOnlyCollection<string> ValidPaymentType = new List<string> { "Paid", "Received" };
        public decimal Amount { get; set; }
        public string PaymentDescription { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public bool IsReceiveable { get; set; }
        public long  Id { get; set; }
    }
}
