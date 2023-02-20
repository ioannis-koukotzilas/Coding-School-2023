using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class ItemRepo : IEntityRepo<Item> {

        public async Task<IList<Item>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();
            var dbItem = await dbContext.Items
                .Include(i => i.TransactionLines)
                .ToListAsync();
            return dbItem;
        }

        public async Task<Item?> GetByIdAsync(int id) {
            using var dbContext = new FuelStationDbContext();
            var dbItem = await dbContext.Items
                .Where(i => i.Id == id)
                .Include(i => i.TransactionLines)
                .SingleOrDefaultAsync();
            return dbItem;
        }

        public async Task AddAsync(Item entity) {
            using var dbContext = new FuelStationDbContext();

            if (entity.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(entity));
            }

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Item entity) {
            using var dbContext = new FuelStationDbContext();
            var dbItem = await dbContext.Items
                .Where(i => i.Id == id)
                .Include(i => i.TransactionLines)
                .SingleOrDefaultAsync();

            if (dbItem == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbItem.Code = entity.Code;
            dbItem.Description = entity.Description;
            dbItem.ItemType = entity.ItemType;
            dbItem.Price = entity.Price;
            dbItem.Cost = entity.Cost;

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