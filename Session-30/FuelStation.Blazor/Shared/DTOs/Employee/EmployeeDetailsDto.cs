using FuelStation.Blazor.Shared.DTOs.Transaction;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Employee {

    public class EmployeeDetailsDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        public List<TransactionDtoEmployee> Transactions { get; set; } = new();

    }

}