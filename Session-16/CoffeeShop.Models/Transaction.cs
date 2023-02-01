using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models {

    public enum PaymentMethodEnum {
        Cash,
        CreditCard
    }

    public class Transaction {

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerID { get; set; } // Foreign key
        public Customer Customer { get; set; } = null!; // Navigation property
        public int EmployeeID { get; set; } // Foreign key
        public Employee Employee { get; set; } = null!;  // Navigation property

        public Transaction() {
            Date = DateTime.Now;
        }

    }
}