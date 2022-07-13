using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class PaymentInsertDto
    {
        public PaymentInsertDto()
        {

        }
        public PaymentInsertDto(Account account, decimal amount, string paymentDescription, string paymentDate,
            string paymentType)
        {
            Account = account;
            AccountId = account.Id;
            Amount = amount;
            PaymentDescription = paymentDescription;
            PaymentDate = paymentDate;
            PaymentType = paymentType;
            if (paymentType == Payment.PaymentTypeReceived)
            {
                IsPaymentReceived = true;
                return;
            }
            IsPaymentReceived = false;
        }
        public virtual Account Account { get; set; }
        public virtual long AccountId { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual string PaymentDescription { get; set; }
        public virtual string PaymentDate { get; set; }
        public virtual string PaymentType { get; set; }
        public virtual bool IsPaymentReceived { get; set; }
    }
}
