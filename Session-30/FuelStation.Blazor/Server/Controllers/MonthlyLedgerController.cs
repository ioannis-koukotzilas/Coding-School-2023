using System.Globalization;
using FuelStation.Blazor.Shared.DTOs.Reports;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Blazor.Server.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public MonthlyLedgerController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo) {
            _employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get() {

            List<MonthlyLedgerDto> monthlyLedgers = new ();

            var dbTransactions = await _transactionRepo.GetAllAsync();
            var dbEmployees = await _employeeRepo.GetAllAsync();

            decimal rent = 5000m;

            var groupTransactions = dbTransactions

                .GroupBy(transactions => new {
                    transactions.Date.Year,
                    transactions.Date.Month
                })

                .Select(group => new MonthlyLedgerDto {
                    Year = group.Key.Year,
                    Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(group.Key.Month),
                    Income = group.Sum(t => t.TotalValue),
                    Expenses = dbEmployees.Sum(e => e.SallaryPerMonth) + rent,
                    Total = group.Sum(t => t.TotalValue) - (dbEmployees.Sum(e => e.SallaryPerMonth) + rent)
                });

            foreach (var grouped in groupTransactions) {
                monthlyLedgers.Add(grouped);
            }

            return monthlyLedgers;
        }

    }

}