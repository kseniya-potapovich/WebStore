﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        public int userId { get; set; }

        public int productId { get; set; }

        public int Quantity { get; set; }
    }
}
