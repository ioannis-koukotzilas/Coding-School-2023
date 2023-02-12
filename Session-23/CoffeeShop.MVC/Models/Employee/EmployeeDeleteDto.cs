using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;
using CoffeeShop.Models.Enums;

namespace CoffeeShop.MVC.Models.Employee {

    public class EmployeeDeleteDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

    }

}