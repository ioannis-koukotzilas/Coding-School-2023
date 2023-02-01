using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models {
    public class Customer {

        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        // Relations
        public Transaction Transaction { get; set; } = null!; // Navigation property

        public Customer() {
            Code = "001";
            Description = "Retail Customer";
        }

    }
}
