﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models {
    public class TransactionLine {

        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int ProductID { get; set; }


    }
}
