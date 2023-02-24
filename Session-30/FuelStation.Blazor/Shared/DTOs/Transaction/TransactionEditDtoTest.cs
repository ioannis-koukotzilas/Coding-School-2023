

using FuelStation.Blazor.Shared.DTOs.TransactionLine;

namespace FuelStation.Blazor.Shared.DTOs.Transaction {

    public class TransactionEditDtoTest {

        public List<TransactionLineDto> TransactionLines { get; set; } = new();

        public decimal TransactionTotalValue => TransactionLines.Sum(tl => tl.TotalValue);


    }

}