using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class AccountUpdateDto:AccountCreateDto
    {
        public long Id { get; set; }
    }
}
