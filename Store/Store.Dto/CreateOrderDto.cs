using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dto
{
    public class CreateOrderDto
    {
        public User Client { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
