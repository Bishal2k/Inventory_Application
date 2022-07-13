using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class PaymentUpdateDto:PaymentInsertDto
    {
        public PaymentUpdateDto(long id, Account account, decimal amount, string paymentDescription, string paymentDate,
            string paymentType) :base(account,amount,paymentDescription,paymentDate,paymentType)
        {
            Id = id;
        }
        public long Id { get; set; }
    }
}
