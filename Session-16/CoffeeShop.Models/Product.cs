namespace CoffeeShop.Models {
    public class Product {

        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public Guid ProductCategoryID { get; set; }

        public Product(string code, string description) {
            ID = Guid.NewGuid();
            Code = code;
            Description = description;
        }

    }
}