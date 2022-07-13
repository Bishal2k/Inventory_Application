using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    
    public class Payment
    {
        public const string PaymentTypeReceived = "PaymentTypeReceived";
        public const string PaymentTypePaied = "PaymentTypePayed";
        protected Payment()
        {

        }
        public Payment(Account account, decimal amount, string paymentDescription,string paymentDate,bool isPaymentReceived)
        {
            Account = account;
            AccountId = account.Id;
            Amount = amount;
            PaymentDescription = paymentDescription;
            PaymentDate = paymentDate;
            if (isPaymentReceived)
            {
                SetPaymentTypeReceived();
                return;
            }
            SetPaymentTypePayed();
        }
        public virtual long Id { get; protected set; }
        public virtual Account Account { get;  set; }
        public virtual long AccountId { get; set; }
        public virtual Decimal Amount { get; set; }
        public virtual string PaymentDescription { get; set; }
        public virtual string PaymentDate { get; set; }
        public virtual string PaymentType { get; set; }

        public virtual void SetPaymentTypeReceived()
        {
            PaymentType = PaymentTypeReceived;
        }
        public virtual void SetPaymentTypePayed()
        {
            PaymentType = PaymentTypePaied;
        }
        public virtual void Update(Account account, decimal amount, string paymentDescription, string paymentDate, bool isPaymentReceived)
        {
            Account = account;
            AccountId = account.Id;
            Amount = amount;
            PaymentDescription = paymentDescription;
            PaymentDate = paymentDate;
            if (isPaymentReceived)
            {
                SetPaymentTypeReceived();
                return;
            }
            SetPaymentTypePayed();
        }
    }
}
