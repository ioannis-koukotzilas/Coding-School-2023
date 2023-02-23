using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Transaction {

    public class TransactionEditDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }

        //public List<CustomerDto> Customers { get; set; } = new();
        //public List<EmployeeDto> Employees { get; set; } = new();


        public string EmployeeName { get; set; } = null!;
        public string EmployeeSurname { get; set; } = null!;
        public EmployeeType EmployeeType { get; set; }

        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;

    }

}