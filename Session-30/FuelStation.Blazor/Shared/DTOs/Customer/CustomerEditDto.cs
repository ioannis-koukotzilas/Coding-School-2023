using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.DTOs.Customer {

    public class CustomerEditDto {

        public int Id { get; set; }
        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Surname is a required field")]
        public string Surname { get; set; } = null!;
        [Required(ErrorMessage = "Card number is a required field")]
        public string CardNumber { get; set; } = null!;

        //public List<TransactionDto> Transactions { get; set; } = new();

    }

}