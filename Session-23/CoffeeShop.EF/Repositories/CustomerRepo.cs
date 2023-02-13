using System;
using CoffeeShop.EF.Context;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {

    public class CustomerRepo : IEntityRepo<Customer> {

        public IList<Customer> GetAll() {
            using var context = new CoffeeShopDbContext();
            return context.Customers.Include(c => c.Transactions).ToList();
        }

        public Customer? GetById(int id) {
            using var context = new CoffeeShopDbContext();
            return context.Customers.Include(c => c.Transactions).SingleOrDefault(c => c.Id == id);
        }

        public void Add(Customer entity) {
            using var context = new CoffeeShopDbContext();
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, Customer entity) {
            using var context = new CoffeeShopDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(c => c.Id == id);
            if (dbCustomer is null)
                return;
            dbCustomer.Code = entity.Code;
            dbCustomer.Description = entity.Description;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbCustomer = context.Customers.Where(c => c.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Customers.Remove(dbCustomer);
            context.SaveChanges();
        }

    }

}