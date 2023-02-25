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
                .Include(t => t.Employee)
                .Include(t => t.Customer)
                .Include(t => t.TransactionLines)
                .SingleOrDefaultAsync(t => t.Id == id);

            return dbTransaction;
        }

        public async Task AddAsync(Transaction transaction) {
            using var dbContext = new FuelStationDbContext();

            if (transaction.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(transaction));
            }

            await dbContext.AddAsync(transaction);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Transaction transaction) {
            using var dbContext = new FuelStationDbContext();
            var dbTransaction = await dbContext.Transactions
                .Include(t => t.Employee)
                .Include(t => t.Customer)
                .Include(t => t.TransactionLines)
                .SingleOrDefaultAsync(t => t.Id == id);

            if (dbTransaction == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbTransaction.Date = transaction.Date;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.TotalValue = transaction.TotalValue;

            // Track Transaction Lines
            dbTransaction.TransactionLines = transaction.TransactionLines;
            //dbTransaction.CustomerId = transaction.CustomerId;
            //dbTransaction.EmployeeId = transaction.EmployeeId;
        
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbTransaction = await dbContext.Transactions.
                SingleOrDefaultAsync(t => t.Id == id);

            if (dbTransaction == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbTransaction);
            await dbContext.SaveChangesAsync();
        }

    }

}

