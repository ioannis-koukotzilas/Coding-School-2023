using System;
using CoffeeShop.EF.Context;
using CoffeeShop.Models;
using CoffeeShop.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {

    public class ProductCategoryRepo : IEntityRepo<ProductCategory> {

        public IList<ProductCategory> GetAll() {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.Include(pc => pc.Products).ToList();
        }

        public ProductCategory? GetById(int id) {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.Include(pc => pc.Products).SingleOrDefault(pc => pc.Id == id);
        }

        public void Add(ProductCategory entity) {
            using var context = new CoffeeShopDbContext();
            context.ProductCategories.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, ProductCategory entity) {
            using var context = new CoffeeShopDbContext();
            var dbProductCat = context.ProductCategories.SingleOrDefault(pc => pc.Id == id);
            if (dbProductCat is null)
                return;
            dbProductCat.Code = entity.Code;
            dbProductCat.Description = entity.Description;
            dbProductCat.ProductType = entity.ProductType;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbProductCat = context.ProductCategories.SingleOrDefault(pc => pc.Id == id);
            if (dbProductCat is null)
                return;
            context.ProductCategories.Remove(dbProductCat);
            context.SaveChanges();

        }

    }

}