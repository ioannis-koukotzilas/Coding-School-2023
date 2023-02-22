using FuelStation.Blazor.Shared.DTOs.Transaction;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Employee {

    public class EmployeeListDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public EmployeeType EmployeeType { get; set; }

        public List<TransactionDtoEmployee> Transactions { get; set; } = new();

    }

}