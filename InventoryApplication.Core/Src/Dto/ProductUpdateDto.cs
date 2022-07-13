using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class ProductUpdateDto:ProductDto
    {
        public ProductUpdateDto(long id, int quantity, string name, double weight):base(name,weight)
        {
            Id = id;
            Quantity = quantity;
        }
        public long Id { get; set; }
        public int Quantity { get; set; }
    }
}
