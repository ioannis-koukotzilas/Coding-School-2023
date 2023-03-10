using System;
using System.ComponentModel.DataAnnotations;
using CoffeeShop.Models.Enums;

namespace CoffeeShop.MVC.Models.ProductCategory {

    public class ProductCategoryCreateDto {

        [Required]
        [MaxLength(20)]
        public string Code { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Description { get; set; } = null!;

        public ProductTypeEnum ProductType { get; set; }

    }

}