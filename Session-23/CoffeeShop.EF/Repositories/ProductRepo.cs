using System;
using CoffeeShop.EF.Context;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {

    public class ProductRepo : IEntityRepo<Product> {

        public IList<Product> GetAll() {
            using var context = new CoffeeShopDbContext();
            return context.Products.Include(p => p.TransactionLines).ToList();
        }

        public Product? GetById(int id) {
            using var context = new CoffeeShopDbContext();
            return context.Products.Where(p => p.Id == id).Include(p => p.TransactionLines).SingleOrDefault();
        }

        public void Add(Product entity) {
            using var context = new CoffeeShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, Product entity) {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (dbProduct is null)
                return;
            dbProduct.Code = entity.Code;
            dbProduct.Description = entity.Description;
            dbProduct.Price = entity.Price;
            dbProduct.Cost = entity.Cost;
            dbProduct.TransactionLines = entity.TransactionLines;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (dbProduct is null)
                return;
            context.Remove(dbProduct);
            context.SaveChanges();
        }

    }

}