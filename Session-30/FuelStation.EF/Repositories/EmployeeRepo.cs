using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class EmployeeRepo : IEntityRepo<Employee> {

        public async Task<IList<Employee>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();

            var dbEmployee = await dbContext.Employees
                .Include(e => e.Transactions)
                .ToListAsync();

            return dbEmployee;
        }

        public async Task<Employee?> GetByIdAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbEmployee = await dbContext.Employees
                .Include(e => e.Transactions)
                .SingleOrDefaultAsync(e => e.Id == id);

            return dbEmployee;
        }

        public async Task AddAsync(Employee employee) {
            using var dbContext = new FuelStationDbContext();

            if (employee.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(employee));
            }

            await dbContext.AddAsync(employee);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Employee employee) {
            using var dbContext = new FuelStationDbContext();

            var dbEmployee = await dbContext.Employees
                 .SingleOrDefaultAsync(e => e.Id == id);

            if (dbEmployee == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.HireDateStart = employee.HireDateStart;
            dbEmployee.HireDateEnd = employee.HireDateEnd;
            dbEmployee.SallaryPerMonth = employee.SallaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
           
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbEmployee = await dbContext.Employees
               .SingleOrDefaultAsync(e => e.Id == id);

            if (dbEmployee == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbEmployee);
            await dbContext.SaveChangesAsync();
        }

    }

}