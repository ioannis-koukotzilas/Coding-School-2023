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
                .Where(e => e.Id == id)
                .Include(e => e.Transactions)
                .SingleOrDefaultAsync();
            return dbEmployee;
        }

        public async Task AddAsync(Employee entity) {
            using var dbContext = new FuelStationDbContext();

            if (entity.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(entity));
            }

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Employee entity) {
            using var dbContext = new FuelStationDbContext();
            var dbEmployee = await dbContext.Employees
                .Where(e => e.Id == id)
                .Include(e => e.Transactions)
                .SingleOrDefaultAsync();

            if (dbEmployee == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.HireDateStart = entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            dbEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
           
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbEmployee = await dbContext.Employees
                .Where(e => e.Id == id)
                .SingleOrDefaultAsync();

            if (dbEmployee == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbEmployee);
            await dbContext.SaveChangesAsync();
        }

    }

}