using System;
using Microsoft.EntityFrameworkCore;
using CoffeeShop.Models;
using CoffeeShop.EF.Configurations;

namespace CoffeeShop.EF.Context {

    public class CoffeeShopDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=CoffeeShop; User ID=sa; Password=uU904291$%!; Integrated Security=False; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);

        }

    }

}