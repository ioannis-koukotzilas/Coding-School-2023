using System;

namespace CoffeeShop.Models {

    public class Customer {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        // Relation (one with many): Transactions per Customer
        public List<Transaction> Transactions { get; set; }

        public Customer(string code, string description) {
            Code = code;
            Description = description;
            Transactions = new List<Transaction>();
        }

    }

}