using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class CustomerRepo : IEntityRepo<Customer> {

        public async Task<IList<Customer>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();
            var dbCustomer = await dbContext.Customers.Include(c => c.Transactions).ToListAsync();
            return dbCustomer;   
        }

        public Customer? GetById(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbCustomer = dbContext.Customers.Where(c => c.Id == id).Include(c => c.Transactions).SingleOrDefault();
            return dbCustomer;
        }

        public void Add(Customer entity) {
            using var dbContext = new FuelStationDbContext();

            if (entity.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(entity));
            }

            dbContext.Add(entity);
            dbContext.SaveChanges();   
        }

        public void Update(int id, Customer entity) {
            using var dbContext = new FuelStationDbContext();
            var dbCustomer = dbContext.Customers.Where(c => c.Id == id).SingleOrDefault();

            if (dbCustomer == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.CardNumber = entity.CardNumber;

            dbContext.SaveChanges();
        }

        public void Delete(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbCustomer = dbContext.Customers.Where(c => c.Id == id).SingleOrDefault();

            if (dbCustomer == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbCustomer);
            dbContext.SaveChanges();
        }

    }

}

