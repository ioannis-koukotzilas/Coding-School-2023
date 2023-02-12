using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.MVC.Models.Customer {

    public class CustomerDeleteDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;

    }

}