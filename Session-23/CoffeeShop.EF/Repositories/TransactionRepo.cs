using System;
using CoffeeShop.EF.Context;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {

    public class TransactionRepo : IEntityRepo<Transaction> {

        public IList<Transaction> GetAll() {
            using var context = new CoffeeShopDbContext();
            return context.Transactions.Include(p => p.TransactionLines).ToList();
        }

        public Transaction? GetById(int id) {
            using var context = new CoffeeShopDbContext();
            return context.Transactions.Include(p => p.TransactionLines).SingleOrDefault(p => p.Id == id);
        }

        public void Add(Transaction entity) {
            using var context = new CoffeeShopDbContext();
            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, Transaction entity) {
            using var context = new CoffeeShopDbContext();
            var dbTransaction = context.Transactions.SingleOrDefault(p => p.Id == id);
            if (dbTransaction is null)
                return;
            dbTransaction.Date = entity.Date;
            dbTransaction.TotalPrice = entity.TotalPrice;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.EmployeeId = entity.EmployeeId;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbTransaction = context.Transactions.SingleOrDefault(p => p.Id == id);
            if (dbTransaction is null)
                return;
            context.Transactions.Remove(dbTransaction);
            context.SaveChanges();
        }

    }

}

