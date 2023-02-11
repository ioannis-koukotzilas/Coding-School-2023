using System;
using System.Transactions;

namespace CoffeeShop.Models {

    public enum ProductTypeEnum {
        Coffee,
        Beverages,
        Food
    }

    public class ProductCategory {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductTypeEnum ProductType { get; set; }

        // Relation (one with many): Products per ProductCategory
        public List<Product> Products { get; set; }

        public ProductCategory(string code, string description, ProductTypeEnum productType) {
            Code = code;
            Description = description;
            ProductType = productType;
            Products = new List<Product>();
        }

    }

}