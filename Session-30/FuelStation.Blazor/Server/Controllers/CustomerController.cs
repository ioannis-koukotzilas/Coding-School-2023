using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase {

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        /* Get all */

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> GetAllCustomers() {

            var dbCustomer = await _customerRepo.GetAllAsync();

            var dbResponse = dbCustomer.Select(c => new CustomerListDto {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                CardNumber = c.CardNumber

            });

            return dbResponse;

        }

        /* Edit */

        /* Add new */

        /* Update */

        /* Delete */



    }

}