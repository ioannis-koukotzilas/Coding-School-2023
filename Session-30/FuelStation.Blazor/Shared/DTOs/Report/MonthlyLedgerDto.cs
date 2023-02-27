namespace FuelStation.Blazor.Shared.DTOs.Reports {

    public class MonthlyLedgerDto {

        public int Year { get; set; }
        public string? Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

    }

}