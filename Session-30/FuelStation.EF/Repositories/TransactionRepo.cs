using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class TranactionRepo : IEntityRepo<Transaction> {

        public async Task<IList<Transaction>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();
            var dbTransaction = await dbContext.Transactions
                .Include(t => t.Employee)
                .Include(t => t.Customer)
                .Include(t => t.TransactionLines)
                .ToListAsync();
            return dbTransaction;
        }

        public async Task<Transaction?> GetByIdAsync(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbTransaction = await dbContext.Transactions
                .Where(t => t.Id == id)
                .Include(t => t.Employee)
                .Include(t => t.Customer)
                .Include(t => t.TransactionLines)
                .SingleOrDefaultAsync();
            return dbTransaction;
        }

        public async Task AddAsync(Transaction entity) {
            using var dbContext = new FuelStationDbContext();

            if (entity.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(entity));
            }

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Transaction entity) {
            using var dbContext = new FuelStationDbContext();
            var dbTransaction = await dbContext.Transactions
                .Where(i => i.Id == id)
                .Include(t => t.Employee)
                .Include(t => t.Customer)
                .Include(t => t.TransactionLines)
                .SingleOrDefaultAsync();

            if (dbTransaction == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbTransaction.Date = entity.Date;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.TotalValue = entity.TotalValue;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.EmployeeId = entity.EmployeeId;
        
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbTransaction = await dbContext.Transactions.
                Where(t => t.Id == id).
                SingleOrDefaultAsync();

            if (dbTransaction == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbTransaction);
            await dbContext.SaveChangesAsync();
        }

    }

}

