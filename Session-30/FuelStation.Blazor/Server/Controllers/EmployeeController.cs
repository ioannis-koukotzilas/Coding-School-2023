using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Employee;
using FuelStation.Blazor.Shared.DTOs.Transaction;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo) {
            _employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> GetAll() {

            var dbEmployees = await _employeeRepo.GetAllAsync();

            var dbResponse = dbEmployees.Select(e => new EmployeeListDto {

                Id = e.Id,
                Name = e.Name,
                Surname = e.Surname,
                EmployeeType = e.EmployeeType,

                Transactions = e.Transactions.Select(t => new TransactionDtoEmployee {
                    Id = t.Id,
                    Date = t.Date,
                    PaymentMethod = t.PaymentMethod,
                    TotalValue = t.TotalValue
                }).ToList()

            });

            return dbResponse;
        }

        [HttpGet("edit/{id}")]
        public async Task<EmployeeEditDto> GetById(int id) {

            var dbEmployee = await _employeeRepo.GetByIdAsync(id);

            if (dbEmployee == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new EmployeeEditDto {

                Id = id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                HireDateStart = dbEmployee.HireDateStart,
                HireDateEnd = dbEmployee.HireDateEnd,
                SallaryPerMonth = dbEmployee.SallaryPerMonth,
                EmployeeType = dbEmployee.EmployeeType
                
            };

            return dbResponse;

        }

    }

}