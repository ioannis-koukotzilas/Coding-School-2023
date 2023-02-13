using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Models.Product {

    public class ProductEditDto {

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Code { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(1, 1000000)]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 1000000)]
        public decimal Cost { get; set; }

        [Display(Name = "Product Category ID")]
        public int ProductCategoryId { get; set; }

        public List<SelectListItem> ProductCategoryList { get; } = new List<SelectListItem>();

    }

}