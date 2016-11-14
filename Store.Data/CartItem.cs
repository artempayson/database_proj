﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    class CartItem
    {
        public int ID { get; set; }
        public Good Good { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
