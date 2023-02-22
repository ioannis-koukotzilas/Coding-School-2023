using FuelStation.Blazor.Shared.DTOs.Transaction;

namespace FuelStation.Blazor.Shared.DTOs.Customer {

    public class CustomerDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string CardNumber { get; set; } = null!;

        public List<TransactionDtoCustomer> Transactions { get; set; } = new();

    }

}