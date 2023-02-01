using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models {

    public enum ProductTypeEnum {
        Coffee,
        Beverages,
        Food
    }

    public class ProductCategory {

        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductTypeEnum ProductType { get; set; }

        public Product Product { get; set; } = null!; // Navigation property

        public ProductCategory(string code, string description) {

            Code = code;
            Description = description;
        
        }

    }
}
