using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Customer;
using FuelStation.Blazor.Shared.DTOs.Transaction;
using Microsoft.EntityFrameworkCore;
using FuelStation.EF.Context;
using FuelStation.Blazor.Server.Services;
using Microsoft.AspNetCore.Authorization;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    //[Authorize(Policy = "Manager")]
    public class CustomerController : ControllerBase {

        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo, IEntityRepo<Transaction> transactionRepo) {
            _customerRepo = customerRepo;
            _transactionRepo = transactionRepo;
        }

        /* Get all entities in a list */
        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> GetAll() {

            var dbCustomers = await _customerRepo.GetAllAsync();

            var dbResponse = dbCustomers.Select(c => new CustomerDto {

                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                CardNumber = c.CardNumber,

                Transactions = c.Transactions.Select(t => new TransactionDtoCustomer {
                    Date = t.Date
                }).ToList()

            });

            return dbResponse;

        }

        /* Get entity by ID to edit */

        [HttpGet("edit/{id}")]
        public async Task<CustomerEditDto> GetById(int id) {

            var dbCustomer = await _customerRepo.GetByIdAsync(id);

            if (dbCustomer == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new CustomerEditDto {

                Id = id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                CardNumber = dbCustomer.CardNumber,

            };

            return dbResponse;

        }

        /* Get entity by ID to list details */

        [HttpGet("details/{id}")]
        public async Task<CustomerDetailsDto> GetDetailsById(int id) {
            var dbCustomer = await _customerRepo.GetByIdAsync(id);

            if (dbCustomer == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new CustomerDetailsDto {

                Id = id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                CardNumber = dbCustomer.CardNumber,

                Transactions = dbCustomer.Transactions.Select(t => new TransactionDtoCustomer {
                    Id = t.Id,
                    Date = t.Date,
                    PaymentMethod = t.PaymentMethod,
                    TotalValue = t.TotalValue
                }).ToList()

            };

            return dbResponse;
        }

        /* Add new entity */

        [HttpPost]
        public async Task Post(CustomerEditDto customer) {

            var dbCustomer = new Customer(
                customer.Name,
                customer.Surname,
                customer.CardNumber
                );

            await _customerRepo.AddAsync(dbCustomer);

        }

        /* Update entity */

        [HttpPut]
        public async Task Put(CustomerEditDto customer) {

            var dbCustomer = await _customerRepo.GetByIdAsync(customer.Id);

            if (dbCustomer == null) {
                throw new ArgumentNullException();
            }

            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;

            await _customerRepo.UpdateAsync(customer.Id, dbCustomer);

        }

        /* Delete Entity */

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _customerRepo.DeleteAsync(id);
        }

        /* Implementation of an algorithm that generates a random card number for the customer entity, checks 
         * if it already exists in the database, and repeats the process until a unique card number is generated. */

        [HttpGet("card-generator")]
        public async Task<string> GenerateCardNumberAsync() {

            var dbCustomers = await _customerRepo.GetAllAsync();

            if (dbCustomers == null) {
                throw new ArgumentNullException();
            }

            Random random = new Random();
            string numbers = "0123456789";
            string cardNumber = "";

            bool cardNumberExists = true;

            // Loop runs as long as cardNumberExists is true
            while (cardNumberExists) {
                cardNumber = "A" + new string(Enumerable.Repeat(numbers, 16).Select(s => s[random.Next(s.Length)]).ToArray());

                // Check if the card number already exists in the database
                var existingCardNumber = dbCustomers.FirstOrDefault(c => c.CardNumber == cardNumber);

                cardNumberExists = existingCardNumber != null;
            }

            return cardNumber;
        }

    }

}








