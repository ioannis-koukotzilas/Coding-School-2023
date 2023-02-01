namespace CoffeeShop.Models {
    public class Product : CoffeeShop {

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public int ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public Product(string code, string description) {
            Code = code;
            Description = description;
        }

    }
}