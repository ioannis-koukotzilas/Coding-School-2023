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

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> GetAll() {

            var dbEmployees = await _employeeRepo.GetAllAsync();

            var dbResponse = dbEmployees.Select(e => new EmployeeListDto {

                Id = e.Id,
                Name = e.Name,
                Surname = e.Surname,
                EmployeeType = e.EmployeeType,

                Transactions = e.Transactions.Select(t => new TransactionEmployeeDto {
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

        [HttpGet("details/{id}")]
        public async Task<EmployeeDetailsDto> GetDetailsById(int id) {
            var dbEmployee = await _employeeRepo.GetByIdAsync(id);

            if (dbEmployee == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new EmployeeDetailsDto {

                Id = id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                HireDateStart = dbEmployee.HireDateStart,
                HireDateEnd = dbEmployee.HireDateEnd,
                SallaryPerMonth = dbEmployee.SallaryPerMonth,
                EmployeeType = dbEmployee.EmployeeType,
              
                Transactions = dbEmployee.Transactions.Select(t => new TransactionEmployeeDto {
                    Id = t.Id,
                    Date = t.Date,
                    PaymentMethod = t.PaymentMethod,
                    TotalValue = t.TotalValue
                }).ToList()

            };

            return dbResponse;
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee) {

            var dbEmployee = new Employee(
                employee.Name,
                employee.Surname,
                employee.HireDateStart,
                employee.HireDateEnd,
                employee.SallaryPerMonth,
                employee.EmployeeType
                );

            await _employeeRepo.AddAsync(dbEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee) {

            var dbEmployee = await _employeeRepo.GetByIdAsync(employee.Id);

            if (dbEmployee == null) {
                throw new ArgumentNullException();
            }

            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.HireDateStart = employee.HireDateStart;
            dbEmployee.HireDateEnd = employee.HireDateEnd;
            dbEmployee.SallaryPerMonth = employee.SallaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;

            await _employeeRepo.UpdateAsync(employee.Id, dbEmployee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _employeeRepo.DeleteAsync(id);
        }

    }

}

