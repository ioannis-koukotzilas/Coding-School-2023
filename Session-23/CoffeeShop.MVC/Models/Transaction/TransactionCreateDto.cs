using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoffeeShop.Models.Enums;

namespace CoffeeShop.MVC.Models.Transaction {

    public class TransactionCreateDto {

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(1, 1000000)]
        public decimal TotalPrice { get; set; }

        [Display(Name = "Payment Method")]
        public PaymentMethodEnum PaymentMethod { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public List<SelectListItem> CustomerList { get; } = new List<SelectListItem>();

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        public List<SelectListItem> EmployeeList { get; } = new List<SelectListItem>();

    }

}