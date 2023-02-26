using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class CustomerRepo : IEntityRepo<Customer> {

        public async Task<IList<Customer>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();

            var dbCustomers = await dbContext.Customers
                .Include(c => c.Transactions).ToListAsync();

            return dbCustomers;
        }

        public async Task<Customer?> GetByIdAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbCustomer = await dbContext.Customers
                .Include(c => c.Transactions)
                .SingleOrDefaultAsync(c => c.Id == id);

            return dbCustomer;
        }

        public async Task AddAsync(Customer customer) {
            using var dbContext = new FuelStationDbContext();

            if (customer.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(customer));
            }

            await dbContext.AddAsync(customer);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Customer customer) {
            using var dbContext = new FuelStationDbContext();

            var dbCustomer = await dbContext.Customers
                .SingleOrDefaultAsync(c => c.Id == id);

            if (dbCustomer == null) {
                throw new KeyNotFoundException($"ID: '{id}' was not found in the database");
            }

            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbCustomer = await dbContext.Customers
                .SingleOrDefaultAsync(c => c.Id == id);

            if (dbCustomer == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbCustomer);
            await dbContext.SaveChangesAsync();
        }

    }

}

