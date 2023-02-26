using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Transaction {

    public class TransactionEmployeeDto {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
    }

}