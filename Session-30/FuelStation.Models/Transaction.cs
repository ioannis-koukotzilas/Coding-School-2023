using FuelStation.Models.Enums;

namespace FuelStation.Models {

    public class Transaction {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        // Relations
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public Transaction(DateTime date, PaymentMethod paymentMethod, decimal totalValue) {
            Date = date;
            PaymentMethod = paymentMethod;
            TotalValue = totalValue;
            TransactionLines = new List<TransactionLine>();
        }

    }

}