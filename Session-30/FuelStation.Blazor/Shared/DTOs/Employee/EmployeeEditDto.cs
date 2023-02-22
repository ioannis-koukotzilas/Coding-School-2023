﻿using System.ComponentModel.DataAnnotations;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Employee {

    public class EmployeeEditDto {

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Surname is a required field")]
        public string Surname { get; set; } = null!;

        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }

        public decimal SallaryPerMonth { get; set; } // TODO: Add a regex for negative inputs

        public EmployeeType EmployeeType { get; set; }

    }

}