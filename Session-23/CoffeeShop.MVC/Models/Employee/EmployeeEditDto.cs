using System;
using CoffeeShop.Models;
using System.ComponentModel.DataAnnotations;
using CoffeeShop.Models.Enums;

namespace CoffeeShop.MVC.Models.Employee {

    public class EmployeeEditDto {

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Surname { get; set; } = null!;

        [Required]
        [Range(1, 1000000)]
        [Display(Name = "Salary / Month")]
        public int SalaryPerMonth { get; set; }

        public EmployeeTypeEnum EmployeeType { get; set; }

    }

}