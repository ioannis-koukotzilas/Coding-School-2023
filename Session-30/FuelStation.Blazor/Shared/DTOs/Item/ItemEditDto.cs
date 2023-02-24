using System.ComponentModel.DataAnnotations;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Shared.DTOs.Item {

    public class ItemEditDto {

        public int Id { get; set; }

        [Required(ErrorMessage = "Item code is a required field")]
        public string Code { get; set; } = null!;

        [Required(ErrorMessage = "Item description is a required field")]
        public string Description { get; set; } = null!;

        public ItemType ItemType { get; set; }

        [Range(0, 9999999.999, ErrorMessage = "Item's price must be a positive number (10, 3)")]
        public decimal Price { get; set; }

        [Range(0, 9999999.999, ErrorMessage = "Item's cost must be a positive number (10, 3)")]
        public decimal Cost { get; set; }

    }

}