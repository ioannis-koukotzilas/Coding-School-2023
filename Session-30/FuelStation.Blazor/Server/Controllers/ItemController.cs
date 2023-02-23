using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using FuelStation.Blazor.Shared.DTOs.Item;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase {

        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo) {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> GetAll() {

            var dbItems = await _itemRepo.GetAllAsync();

            var dbResponse = dbItems.Select(i => new ItemListDto {

                Id = i.Id,
                Code = i.Code,
                Description = i.Description,
                ItemType = i.ItemType,
                Price = i.Price,
                Cost = i.Cost

            });

            return dbResponse;
        }

        [HttpGet("edit/{id}")]
        public async Task<ItemEditDto> GetById(int id) {

            var dbItem = await _itemRepo.GetByIdAsync(id);

            if (dbItem == null) {
                throw new ArgumentNullException();
            }

            var dbResponse = new ItemEditDto {

                Id = id,
                Code = dbItem.Code,
                Description = dbItem.Description,
                ItemType = dbItem.ItemType,
                Price = dbItem.Price,
                Cost = dbItem.Cost
                
            };

            return dbResponse;
        }

        [HttpPost]
        public async Task Post(ItemEditDto item) {

            var dbItem = new Item(
                item.Code,
                item.Description,
                item.ItemType,
                item.Price,
                item.Cost
                );

            await _itemRepo.AddAsync(dbItem);
        }

        [HttpPut]
        public async Task Put(ItemEditDto item) {

            var dbItem = await _itemRepo.GetByIdAsync(item.Id);

            if (dbItem == null) {
                throw new ArgumentNullException();
            }

            dbItem.Code = item.Code;
            dbItem.Description = item.Description;
            dbItem.ItemType = item.ItemType;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;
            
            await _itemRepo.UpdateAsync(item.Id, dbItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _itemRepo.DeleteAsync(id);
        }

    }

}