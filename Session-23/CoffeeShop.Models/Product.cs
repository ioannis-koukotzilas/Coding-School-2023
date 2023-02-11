using System;
using System.Transactions;

namespace CoffeeShop.Models {

    public class Product {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relation: Prouct includes the ProductCategoryId
        public ProductCategory ProductCategory { get; set; } = null!;
        public int ProductCategoryId { get; set; }

        // Relation (one with many): TransactionLines per Product
        public List<TransactionLine> TransactionLines { get; set; }

        public Product(string code, string description, decimal price, decimal cost) {
            Code = code;
            Description = description;
            Price = price;
            Cost = cost;
            TransactionLines = new List<TransactionLine>();
        }

    }

}