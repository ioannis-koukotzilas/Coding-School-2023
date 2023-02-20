using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Customer;
using FuelStation.Blazor.Shared.DTOs.Transaction;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase {

        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo, IEntityRepo<Transaction> transactionRepo) {
            _customerRepo = customerRepo;
            _transactionRepo = transactionRepo;
        }

        /* Get all entities in a list */

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> GetAll() {

            var dbCustomer = await _customerRepo.GetAllAsync();

            var dbResponse = dbCustomer.Select(c => new CustomerListDto {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                CardNumber = c.CardNumber

            });

            return dbResponse;

        }

        /* Get entity by ID */

        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id) {

            var dbCustomer = await _customerRepo.GetByIdAsync(id);
            
            if (dbCustomer == null) {
                throw new ArgumentNullException();
            }

            var dbTransactions = await _transactionRepo.GetAllAsync();

            var dbResponse = new CustomerEditDto {

                Id = id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                CardNumber = dbCustomer.CardNumber,
                
                
                Transactions = dbTransactions.Select(t => new TransactionListDto {
                    Id = t.Id,
                    Date = t.Date

                }).ToList()

            };

            return dbResponse;

        }

        /* Add new entity */

        [HttpPost]
        public async Task Post(CustomerEditDto entity) {

            var dbEntity = new Customer(
                entity.Name,
                entity.Surname,
                entity.CardNumber
                );

            await _customerRepo.AddAsync(dbEntity);

        }

        /* Update entity */

        [HttpPut]
        public async Task Put(CustomerEditDto entity) {

            var dbEntity = await _customerRepo.GetByIdAsync(entity.Id);

            if (dbEntity == null) {
                throw new ArgumentNullException();
            }

            dbEntity.Name = entity.Name;
            dbEntity.Surname = entity.Surname;
            dbEntity.CardNumber = entity.CardNumber;

            await _customerRepo.UpdateAsync(entity.Id, dbEntity);

        }

        /* Delete Entity */

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _customerRepo.DeleteAsync(id);
        }

    }

}








