using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.MVC.Models.Customer {

    public class CustomerCreateDto {

        [Required]
        [Display(Name = "Customer Code")]
        [MaxLength(20, ErrorMessage = "Please enter up to 20 characters")]
        public string Code { get; set; } = null!;

        [Required]
        [Display(Name = "Customer Description")]
        [MaxLength(150, ErrorMessage = "Please enter up to 150 characters")]
        public string Description { get; set; } = null!;

    }

}