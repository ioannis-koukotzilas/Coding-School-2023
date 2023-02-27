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

            List<MonthlyLedgerDto> monthlyLedgers = new();

            var dbTransactions = await _transactionRepo.GetAllAsync();

            var dbEmployees = await _employeeRepo.GetAllAsync();

            decimal totalTransactions = 0;
            decimal totalSallaries = 0;
            decimal rent = 5000m;

            foreach (var t in dbTransactions) {
                totalTransactions += t.TotalValue;
            }

            foreach (var e in dbEmployees) {
                totalSallaries += e.SallaryPerMonth;
            }

            var groupTransactions = dbTransactions

                .GroupBy(transactions => new {
                    transactions.Date.Year,
                    transactions.Date.Month
                })

                .Select(group => new MonthlyLedgerDto {
                    Year = group.Key.Year,
                    Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(group.Key.Month),
                    Income = totalTransactions,
                    Expenses = totalSallaries + rent,
                    Total = totalTransactions - (totalSallaries + rent)
                });

            foreach (var grouped in groupTransactions) {
                monthlyLedgers.Add(grouped);
            }

            return groupTransactions;
        }

    }

}