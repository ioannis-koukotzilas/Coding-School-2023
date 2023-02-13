using System;
using CoffeeShop.EF.Context;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {

    public class ProductRepo : IEntityRepo<Product> {

        public IList<Product> GetAll() {
            using var context = new CoffeeShopDbContext();
            return context.Products.Include(p => p.ProductCategory).ToList();
        }

        public Product? GetById(int id) {
            using var context = new CoffeeShopDbContext();
            return context.Products.Include(p => p.ProductCategory).SingleOrDefault(p => p.Id == id);
        }

        public void Add(Product entity) {
            using var context = new CoffeeShopDbContext();
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, Product entity) {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.SingleOrDefault(p => p.Id == id);
            if (dbProduct is null)
                return;
            dbProduct.Code = entity.Code;
            dbProduct.Description = entity.Description;
            dbProduct.Price = entity.Price;
            dbProduct.Cost = entity.Cost;
            dbProduct.ProductCategoryId = entity.ProductCategoryId;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.SingleOrDefault(p => p.Id == id);
            if (dbProduct is null)
                return;
            context.Products.Remove(dbProduct);
            context.SaveChanges();
        }

    }

}

