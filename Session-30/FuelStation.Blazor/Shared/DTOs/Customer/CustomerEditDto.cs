using System.ComponentModel.DataAnnotations;
using FuelStation.Blazor.Shared.DTOs.Transaction;

namespace FuelStation.Blazor.Shared.DTOs.Customer {

    public class CustomerEditDto {

        public int Id { get; set; }
        [Required(ErrorMessage = "Customer's name is required field")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Customer's surname is required field")]
        public string Surname { get; set; } = null!;
        [Required(ErrorMessage = "Required field")]
        public string CardNumber { get; set; } = null!;

        //public List<TransactionDto> Transactions { get; set; } = new();

    }

}