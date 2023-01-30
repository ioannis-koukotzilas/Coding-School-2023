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

        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductTypeEnum ProductType { get; set; }

        public ProductCategory(string code, string description) {

            ID= Guid.NewGuid();
            Code = code;
            Description = description;
        
        }

    }
}
