using InventoryApplication.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class AccountCreateDto
    {
        public Profile Profile { get; set; }
        public decimal? AmountPayable { get; set; }
        public decimal? AmountReceiveable { get; set; }
    }
}
