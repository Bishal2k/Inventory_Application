using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class BillUpdateDto:BillInsertDto
    {
        public long Id { get; set; }
    }
}
