using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Reports;
using System.Globalization;

namespace FuelStation.Blazor.Server.Controllers {

    public class MonthlyLedgerController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;

        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> GetAll() {

            var dbTransactions = await _transactionRepo.GetAllAsync();

            foreach (var date in dbTransactions) {
                date.Date = new DateTime(
                    date.Date.Year,
                    date.Date.Month,
                    1
                    );
            }


            var dbResponse = dbTransactions.GroupBy(x => x.Date).Select(ledger => new MonthlyLedgerDto {

               Year = ledger.First().Date.Year,
               Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ledger.First().Date.Month),
               Income = ledger.Sum(t => t.TotalValue),
               //Expenses = GetExpenses(ledger)

            });

            return dbResponse;
        }

       

    }

}