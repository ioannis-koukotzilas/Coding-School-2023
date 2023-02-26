using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Transaction;
using FuelStation.Blazor.Shared.DTOs.Customer;
using FuelStation.Blazor.Shared.DTOs.TransactionLine;
using FuelStation.Blazor.Shared.DTOs.Item;
using FuelStation.Models.Enums;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeerRepo;
        private readonly IEntityRepo<Item> _itemRepo;

        public TransactionController(

            IEntityRepo<Transaction> transactionRepo,
            IEntityRepo<Customer> customerRepo,
            IEntityRepo<Employee> employeerRepo,
            IEntityRepo<Item> itemRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeerRepo = employeerRepo;
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> GetAll() {

            var dbTransactions = await _transactionRepo.GetAllAsync();

            var dbResponse = dbTransactions.Select(t => new TransactionListDto {

                Id = t.Id,
                Date = t.Date,
                PaymentMethod = t.PaymentMethod,
                TotalValue = t.TotalValue,

                EmployeeId = t.EmployeeId,
                CustomerId = t.Customer.Id,

                EmployeeName = t.Employee.Name,
                EmployeeSurname = t.Employee.Surname,
                EmployeeType = t.Employee.EmployeeType,

                CustomerName = t.Customer.Name,
                CustomerSurname = t.Customer.Surname

            });

            return dbResponse;
        }

        [HttpGet("edit/{id}")]
        public async Task<TransactionEditDto> GetById(int id) {

            var dbTransaction = await _transactionRepo.GetByIdAsync(id);

            if (dbTransaction == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new TransactionEditDto {

                Id = id,
                Date = dbTransaction.Date,
                PaymentMethod = dbTransaction.PaymentMethod,
                TotalValue = dbTransaction.TotalValue,

                EmployeeId = dbTransaction.EmployeeId,
                CustomerId = dbTransaction.CustomerId,

                // Include Transaction Lines
                TransactionLines = dbTransaction.TransactionLines.Select(tl => new TransactionLineDto {
                    Id = tl.Id,
                    Quantity = tl.Quantity,
                    ItemPrice = tl.ItemPrice,
                    NetValue = tl.NetValue,
                    DiscountPercent = tl.DiscountPercent,
                    DiscountValue = tl.DiscountValue,
                    TotalValue = tl.TotalValue,

                    ItemId = tl.ItemId,

                }).ToList()

            };

            return dbResponse;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {

            // Calculate the total value based on the transaction lines
            transaction.TotalValue = transaction.TransactionLines.Sum(tl => tl.TotalValue);

            var dbTransaction = new Transaction(
                transaction.Date,
                transaction.PaymentMethod,
                transaction.TotalValue
            );

            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;

            foreach (var tl in transaction.TransactionLines) {

                var dbTransactionLine = new TransactionLine(
                    tl.Quantity,
                    tl.ItemPrice,
                    tl.NetValue,
                    tl.DiscountPercent,
                    tl.DiscountValue,
                    tl.TotalValue
                );

                dbTransactionLine.ItemId = tl.ItemId;

                dbTransaction.TransactionLines.Add(dbTransactionLine);
            }

            // Business rule: If the TotalValue of the transaction is above 50 Euros, the only acceptable payment method is Cash.
            if (dbTransaction.TotalValue > 50m && dbTransaction.PaymentMethod != PaymentMethod.Cash) {
                throw new InvalidOperationException("The only acceptable payment method for a transaction with a Total Value above 50 Euros is Cash.");
            }

            await _transactionRepo.AddAsync(dbTransaction);
        }

        [HttpPut]
        public async Task Put(TransactionEditDto transaction) {

            var dbTransaction = await _transactionRepo.GetByIdAsync(transaction.Id);

            if (dbTransaction == null) {
                throw new ArgumentNullException();
            }

            dbTransaction.Date = transaction.Date;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;

            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;

            dbTransaction.TransactionLines = transaction.TransactionLines

                .Select(tl => new TransactionLine(

                    tl.Quantity,
                    tl.ItemPrice,
                    tl.NetValue,
                    tl.DiscountPercent,
                    tl.DiscountValue,
                    tl.TotalValue
                    ) {

                    Id = tl.Id,
                    ItemId = tl.ItemId // Important!

                }).ToList();

            // Calculate the total value based on the transaction lines
            dbTransaction.TotalValue = dbTransaction.TransactionLines.Sum(tl => tl.TotalValue);

            // Business rule: If the TotalValue of the transaction is above 50 Euros, the only acceptable payment method is Cash.
            if (dbTransaction.TotalValue > 50m && dbTransaction.PaymentMethod != PaymentMethod.Cash) {
                throw new InvalidOperationException("The only acceptable payment method for a transaction with a Total Value above 50 Euros is Cash.");
            }

            await _transactionRepo.UpdateAsync(transaction.Id, dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _transactionRepo.DeleteAsync(id);
        }

    }

}