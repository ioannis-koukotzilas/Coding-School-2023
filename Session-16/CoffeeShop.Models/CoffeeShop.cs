﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models {
   
    public abstract class CoffeeShop : ICoffeeShop { 
    
        public Guid ID { get; set; }

        public CoffeeShop() {
            ID = Guid.NewGuid();
        }

        // Test commit

    }

}
