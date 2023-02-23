using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Transaction;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeerRepo;

        public TransactionController(

            IEntityRepo<Transaction> transactionRepo,
            IEntityRepo<Customer> customerRepo,
            IEntityRepo<Employee> employeerRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeerRepo = employeerRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionDto>> GetAll() {

            var dbTransactions = await _transactionRepo.GetAllAsync();

            var dbResponse = dbTransactions.Select(t => new TransactionDto {

                Id = t.Id,
                Date = t.Date,
                PaymentMethod = t.PaymentMethod,
                TotalValue = t.TotalValue,

                EmployeeId = t.EmployeeId,
                EmployeeName = t.Employee.Name,
                EmployeeSurname = t.Employee.Surname,
                EmployeeType = t.Employee.EmployeeType,

                CustomerId = t.Customer.Id,
                CustomerName = t.Customer.Name,
                CustomerSurname = t.Customer.Surname,

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
               
               // Rest

            };

            return dbResponse;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {

            var dbTransaction = new Transaction(
               transaction.Date,
               transaction.PaymentMethod,
               transaction.TotalValue

               // Rest

                );

            await _transactionRepo.AddAsync(dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _transactionRepo.DeleteAsync(id);
        }

    }

}