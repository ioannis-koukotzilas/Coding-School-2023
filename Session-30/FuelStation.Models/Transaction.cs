using FuelStation.Models.Enums;

namespace FuelStation.Models {

    public class Transaction {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        // Foreign keys
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }

        // Navigation properties
        public List<TransactionLine> TransactionLines { get; set; }     
        public Employee Employee { get; set; } = null!;      
        public Customer Customer { get; set; } = null!;

        public Transaction(DateTime date, PaymentMethod paymentMethod, decimal totalValue) {
            Date = date;
            PaymentMethod = paymentMethod;
            TotalValue = totalValue;
            TransactionLines = new List<TransactionLine>();
        }

    }

}