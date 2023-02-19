using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Customer;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase {

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        /* Get all entities in a list */

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> GetAll() {

            var dbEntity = await _customerRepo.GetAllAsync();

            var dbResponse = dbEntity.Select(e => new CustomerListDto {
                Id = e.Id,
                Name = e.Name,
                Surname = e.Surname,
                CardNumber = e.CardNumber

            });

            return dbResponse;

        }

        /* Get entity by ID */

        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id) {

            var dbEntity = await _customerRepo.GetByIdAsync(id);

            if (dbEntity == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new CustomerEditDto {
                Id = id,
                Name = dbEntity.Name,
                Surname = dbEntity.Surname,
                CardNumber = dbEntity.CardNumber
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