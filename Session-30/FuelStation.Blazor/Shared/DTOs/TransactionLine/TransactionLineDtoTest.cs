using FuelStation.Blazor.Shared.DTOs.Item;

namespace FuelStation.Blazor.Shared.DTOs.TransactionLine {

    public class TransactionLineDto {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        public int ItemId { get; set; }

        public List<ItemEditDto> Items { get; set; } = new();

    }

}