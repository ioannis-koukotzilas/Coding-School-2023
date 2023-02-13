using System;
using CoffeeShop.EF.Context;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories {

    public class EmployeeRepo : IEntityRepo<Employee> {

        public IList<Employee> GetAll() {
            using var context = new CoffeeShopDbContext();
            return context.Employees.Include(e => e.Transactions).ToList();
        }

        public Employee? GetById(int id) {
            using var context = new CoffeeShopDbContext();
            return context.Employees.Include(e => e.Transactions).SingleOrDefault(e => e.Id == id);
        }

        public void Add(Employee entity) {
            using var context = new CoffeeShopDbContext();
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, Employee entity) {
            using var context = new CoffeeShopDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(e => e.Id == id);
            if (dbEmployee is null)
                return;
            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CoffeeShopDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(e => e.Id == id);
            if (dbEmployee is null)
                return;
            context.Employees.Remove(dbEmployee);
            context.SaveChanges();
        }

    }

}