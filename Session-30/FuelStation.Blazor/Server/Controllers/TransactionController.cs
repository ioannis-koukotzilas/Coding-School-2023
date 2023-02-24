using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Transaction;
using FuelStation.Blazor.Shared.DTOs.Customer;
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
                    TotalValue = tl.TotalValue
                }).ToList()

            };

            return dbResponse;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {

            var dbTransaction = new Transaction(
               transaction.Date,
               transaction.PaymentMethod,
               transaction.TotalValue
            );

            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;

            foreach (var tl in transaction.TransactionLines) {

                /* Business:
                 * Net Value is calculated by multiplying the quantity with the item price. 
                 * Discount Value is calculated by multiplying Net Value by Discount Percent.
                 * Total Value is calculated by subtracting Discount Value from the Net Value.
                 * If a Transaction Line includes an item of the type Fuel and its NetValue is 
                 * above 20 euros, then we calculate a 10% discount on that transaction line. */

                var netValue = tl.Quantity * tl.ItemPrice;
                var discountValue = netValue * (tl.DiscountPercent / 100m);
                var totalValue = netValue - discountValue;

                // Retrieve the Item object from the database
                var item = await _itemRepo.GetByIdAsync(tl.ItemId);

                if (item == null) {
                    throw new NullReferenceException("Transaction Line Item is null.");
                }

                if (item.ItemType == ItemType.Fuel && netValue > 20) {
                    var fuelDiscount = netValue * 0.1m;
                    discountValue += fuelDiscount;
                    totalValue -= fuelDiscount;
                }

                var dbTransactionLine = new TransactionLine(
                    tl.Quantity,
                    tl.ItemPrice,
                    netValue,
                    tl.DiscountPercent,
                    discountValue,
                    totalValue
                );

                dbTransactionLine.ItemId = tl.ItemId;

                dbTransaction.TransactionLines.Add(dbTransactionLine);
            }

            /* Business: 
             * If the TotalValue of the transaction is above 50 Euros, the only acceptable payment method is Cash. */

            if (dbTransaction.TotalValue > 50m && dbTransaction.PaymentMethod != PaymentMethod.Cash) {
                throw new InvalidOperationException("The only acceptable payment method for a transaction with a Total Value above 50 Euros is Cash.");
            }

            await _transactionRepo.AddAsync(dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _transactionRepo.DeleteAsync(id);
        }

    }

}


