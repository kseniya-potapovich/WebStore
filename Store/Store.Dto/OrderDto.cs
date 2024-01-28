using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class OrderDto: CreateOrderDto
    {
        public int Id { get; set; }
    }
}
