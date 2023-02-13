using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.MVC.Models.Product {

    public class ProductDeleteDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }

    }

}