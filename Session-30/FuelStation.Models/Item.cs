using FuelStation.Models.Enums;

namespace FuelStation.Models {

    public class Item {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Item(string code, string description, ItemType itemType, decimal price, decimal cost) {
            Code = code;
            Description = description;
            ItemType = itemType;
            Price = price;
            Cost = cost;
        }

    }

}