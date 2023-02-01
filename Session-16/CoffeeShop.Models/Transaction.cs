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

    public class Transaction : CoffeeShop {
        
        public DateTime Date { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

        public Transaction() {
            Date = DateTime.Now;
        }

    }
}
