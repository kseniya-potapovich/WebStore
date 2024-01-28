using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class CreateProductDto
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
