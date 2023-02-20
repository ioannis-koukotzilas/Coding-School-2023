using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class TranactionLineRepo : IEntityRepo<TransactionLine> {

        public async Task<IList<TransactionLine>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();
            var dbTransactionLine = await dbContext.TransactionLines
                .Include(tl => tl.Item)
                .Include(tl => tl.Transaction)
                .ToListAsync();
            return dbTransactionLine;
        }

        public async Task<TransactionLine?> GetByIdAsync(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbTransactionLine = await dbContext.TransactionLines
                .Where(tl => tl.Id == id)
                .Include(tl => tl.Item)
                .Include(tl => tl.Transaction)
                .SingleOrDefaultAsync();
            return dbTransactionLine;
        }

        public async Task AddAsync(TransactionLine entity) {
            using var dbContext = new FuelStationDbContext();

            if (entity.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(entity));
            }

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, TransactionLine entity) {
            using var dbContext = new FuelStationDbContext();
            var dbTransactionLine = await dbContext.TransactionLines
                .Where(tl => tl.Id == id)
                .Include(tl => tl.Item)
                .Include(tl => tl.Transaction)
                .SingleOrDefaultAsync();

            if (dbTransactionLine == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbTransactionLine.Quantity = entity.Quantity;
            dbTransactionLine.ItemPrice = entity.ItemPrice;
            dbTransactionLine.NetValue = entity.NetValue;
            dbTransactionLine.DiscountPercent = entity.DiscountPercent;
            dbTransactionLine.DiscountValue = entity.DiscountValue;
            dbTransactionLine.TotalValue = entity.TotalValue;
            dbTransactionLine.TransactionId = entity.TransactionId;
            dbTransactionLine.ItemId = entity.ItemId;
           
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