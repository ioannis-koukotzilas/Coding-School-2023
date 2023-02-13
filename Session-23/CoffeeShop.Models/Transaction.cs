using System;
using System.Transactions;
using CoffeeShop.Models.Enums;

namespace CoffeeShop.Models {

    public class Transaction {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }

        // Relation: Transaction includes the CustomerId
        public Customer Customer { get; set; } = null!;
        public int CustomerId { get; set; }

        // Relation: Transaction includes the EmployeeId
        public Employee Employee { get; set; } = null!;
        public int EmployeeId { get; set; }

        // Relation (one with many): Transaction Lines per Transaction
        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction(DateTime date, decimal totalPrice, PaymentMethodEnum paymentMethod) {
            Date = DateTime.Now;
            TotalPrice = totalPrice;
            PaymentMethod = paymentMethod;
            TransactionLines = new List<TransactionLine>();

        }

    }

}