using InventoryApplication.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Models.Entity
{
    public class Account
    {
        public Account()
        {
            AmountPayable = 0m;
            AmountReceiveable = 0m;
        }
        public virtual long Id { get; protected set; }
        public virtual Profile Profile { get; set; }
        public virtual  long ProfileId { get; set; }
        public virtual decimal? AmountPayable { get; set; }
        public virtual decimal? AmountReceiveable { get; set; }
        public virtual void DeductPayable(decimal amount)
        {
            if (AmountPayable > 0)
            {
                if (AmountPayable >= amount)
                {
                    AmountPayable -= amount;
                    return;
                }
                throw new InconsistentAmountException($"तिर्नु पर्ने रकम भन्दा ठूलो रकम भेटियो। तिर्नु पर्ने कुल रकम {AmountPayable} हो");               
            }
            throw new InconsistentAmountException("कुनै देय रकम बाँकी छैन।");
        }
        public virtual void DeductReceiveable(decimal amount)
        {
            if (AmountReceiveable > 0)
            {
                if (AmountReceiveable >= amount)
                {
                    AmountReceiveable -= amount;
                    return;
                }
                throw new InconsistentAmountException($"तिर्नु पर्ने रकम भन्दा ठूलो रकम भेटियो। तिर्नु पर्ने कुल रकम {AmountReceiveable} हो");
            }
            throw new InconsistentAmountException("कुनै देय रकम बाँकी छैन।");
        }
        public virtual void UpdatePayableAmount(decimal amount)
        {
            AmountPayable = amount;
        }
        public virtual void UpdatePaymentReceiveable(decimal amount)
        {
            AmountReceiveable = amount;
        }
    }
    
}
