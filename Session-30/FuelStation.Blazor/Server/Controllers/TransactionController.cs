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

        /* Get all entities in a list */

        [HttpGet]
        public async Task<IEnumerable<TransactionDto>> GetAll() {

            var dbEntity = await _transactionRepo.GetAllAsync();

            var dbResponse = dbEntity.Select(e => new TransactionDto {
                Id = e.Id,
                Date = e.Date,
                EmployeeId = e.EmployeeId,
                EmployeeName = e.Employee.Name,
                EmployeeSurname = e.Employee.Surname,
                EmployeeType = e.Employee.EmployeeType,
                CustomerId = e.Customer.Id,
                CustomerName = e.Customer.Name,
                CustomerSurname = e.Customer.Surname,
                PaymentMethod = e.PaymentMethod,
                TotalValue = e.TotalValue,
            });

            return dbResponse;

        }

    }

}