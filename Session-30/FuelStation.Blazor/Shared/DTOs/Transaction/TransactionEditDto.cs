using FuelStation.Blazor.Shared.DTOs.Customer;
using FuelStation.Blazor.Shared.DTOs.Employee;
using FuelStation.Blazor.Shared.DTOs.TransactionLine;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Transaction {

    public class TransactionEditDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }

        public List<CustomerEditDto> Customers { get; set; } = new();
        public List<EmployeeEditDto> Employees { get; set; } = new();

        public List<TransactionLineDto> TransactionLines { get; set; } = new();

        public decimal TransactionTotalValue => TransactionLines.Sum(tl => tl.TotalValue);

    }

}