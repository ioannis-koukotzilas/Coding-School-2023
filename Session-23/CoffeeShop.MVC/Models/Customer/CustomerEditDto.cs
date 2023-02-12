using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.MVC.Models.Customer {

    public class CustomerEditDto {

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Code { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Description { get; set; } = null!;

    }

}