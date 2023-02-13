using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;
using CoffeeShop.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Models.Transaction {

    public class TransactionDeleteDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

    }

}