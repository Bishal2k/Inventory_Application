using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Exceptions
{
    public class InconsistentAmountException:Exception
    {
        public InconsistentAmountException(string message):base(message)
        {

        }
    }
}
