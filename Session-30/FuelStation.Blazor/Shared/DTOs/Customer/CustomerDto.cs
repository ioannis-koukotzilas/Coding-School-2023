namespace FuelStation.Blazor.Shared.DTOs.Customer {

    public class CustomerDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string CardNumber { get; set; } = null!;

    }

}