using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Dto
{
    public class ProductDto
    {
        public ProductDto(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
