using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;
using CoffeeShop.Models.Enums;

namespace CoffeeShop.MVC.Models.ProductCategory {

    public class ProductCategoryDeleteDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ProductTypeEnum ProductType { get; set; }

    }

}