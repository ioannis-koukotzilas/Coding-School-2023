using System;

namespace CoffeeShop.Models {

    public class TransactionLine {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

        // Relation: TransactionLine includes the TransactionId
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        // Relation: TransactionLine includes the ProductId
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public TransactionLine(int quantity, decimal price, decimal discount, decimal totalPrice) {
            Quantity = quantity;
            Price = price;
            Discount = discount;
            TotalPrice = totalPrice;
        }

    }

}

