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
        
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }

        public Transaction() {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }

    }
}
