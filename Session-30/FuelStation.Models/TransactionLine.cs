namespace FuelStation.Models {

    public class TransactionLine {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public TransactionLine(int quantity, decimal itemPrice, decimal netValue, decimal discountPercent, decimal discountValue, decimal totalValue) {
            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = netValue;
            DiscountPercent = discountPercent;
            DiscountValue = discountValue;
            TotalValue = totalValue;
        }

    }

}