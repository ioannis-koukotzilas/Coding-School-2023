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
            return context.ProductCategories.Where(pc => pc.Id == id).Include(e => e.Products).SingleOrDefault();
        }

        public void Add(ProductCategory entity) {
            using var context = new CoffeeShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, ProductCategory entity) {
            using var context = new CoffeeShopDbContext();
            var dbProductCat = context.ProductCategories.Where(pc => pc.Id == id).SingleOrDefault();
            if (dbProductCat is null)
                return;
            dbProductCat.Code = entity.Code;
            dbProductCat.Description = entity.Description;
            dbProductCat.ProductType = entity.ProductType;
            dbProductCat.Products = entity.Products;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbProductCat = context.ProductCategories.Where(pc => pc.Id == id).SingleOrDefault();
            if (dbProductCat is null)
                return;
            context.Remove(dbProductCat);
            context.SaveChanges();

        }

    }

}