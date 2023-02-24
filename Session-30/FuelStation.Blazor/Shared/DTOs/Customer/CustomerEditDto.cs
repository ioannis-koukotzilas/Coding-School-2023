using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.DTOs.Customer {

    public class CustomerEditDto {

        public int Id { get; set; }

        [Required(ErrorMessage = "Customer name is a required field")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Customer surname is a required field")]
        public string Surname { get; set; } = null!;

        [Required(ErrorMessage = "Customer card number is a required field")]
        public string CardNumber { get; set; } = null!;

    }

}