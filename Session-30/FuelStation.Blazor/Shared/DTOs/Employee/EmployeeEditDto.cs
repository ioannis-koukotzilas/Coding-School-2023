using System.ComponentModel.DataAnnotations;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Employee {

    public class EmployeeEditDto {

        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is a required field")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Employee surname is a required field")]
        public string Surname { get; set; } = null!;

        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }

        [Range(0, 99999999.99, ErrorMessage = "Employee's salary must be a positive number (10, 2)")]
        public decimal SallaryPerMonth { get; set; }

        public EmployeeType EmployeeType { get; set; }

    }

}