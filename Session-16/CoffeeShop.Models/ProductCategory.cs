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

    public class ProductCategory : CoffeeShop {

        public string Code { get; set; }
        public string Description { get; set; }
        public ProductTypeEnum ProductType { get; set; }
        public Product Product { get; set; }

        public ProductCategory(string code, string description) {

            Code = code;
            Description = description;
        
        }

    }
}
