using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Exceptions
{
    public class DuplicateEntryException:Exception
    {
        public DuplicateEntryException(string message= "आइटम पहिले रेकर्ड गरिएको छ।") :base(message)
        {

        }
    }
}
