using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Item {

    public class ItemListDto {

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }

}