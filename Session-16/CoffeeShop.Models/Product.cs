namespace CoffeeShop.Models {
    public class Product {

        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public int ProductCategoryID { get; set; } // Foreign key
        public ProductCategory ProductCategory { get; set; } = null!; // Navigation property
        public TransactionLine TransactionLine { get; set; } = null!; // Navigation property

        public Product(string code, string description) {
            Code = code;
            Description = description;
        }

    }
}