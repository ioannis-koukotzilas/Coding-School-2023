using FuelStation.Models;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {

    public class ItemRepo : IEntityRepo<Item> {

        public async Task<IList<Item>> GetAllAsync() {
            using var dbContext = new FuelStationDbContext();

            var dbItem = await dbContext.Items
                .ToListAsync();

            return dbItem;
        }

        public async Task<Item?> GetByIdAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbItem = await dbContext.Items
                .Include(i => i.TransactionLines)
                .SingleOrDefaultAsync(i => i.Id == id);

            return dbItem;
        }

        public async Task AddAsync(Item item) {
            using var dbContext = new FuelStationDbContext();

            if (item.Id != 0) {
                throw new ArgumentException("Given entity should not have an ID set", nameof(item));
            }

            await dbContext.AddAsync(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Item item) {
            using var dbContext = new FuelStationDbContext();

            var dbItem = await dbContext.Items
                .SingleOrDefaultAsync(i => i.Id == id);

            if (dbItem == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbItem.Code = item.Code;
            dbItem.Description = item.Description;
            dbItem.ItemType = item.ItemType;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            using var dbContext = new FuelStationDbContext();

            var dbItem = await dbContext.Items
                .SingleOrDefaultAsync(i => i.Id == id);

            if (dbItem == null) {
                throw new KeyNotFoundException($"Given ID '{id}' was not found in the database");
            }

            dbContext.Remove(dbItem);
            await dbContext.SaveChangesAsync();
        }

    }

}