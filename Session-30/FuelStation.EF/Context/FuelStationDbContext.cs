using Microsoft.EntityFrameworkCore;
using FuelStation.EF.Configurations;
using FuelStation.Models;

namespace FuelStation.EF.Context {

    public class FuelStationDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<TransactionLine> TransactionLines { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            var connectionString =
                "Data Source = localhost;" +
                "Initial Catalog = FuelStation;" +
                "User Id = sa;" +
                "Password = uU904291$%!;" +
                "Encrypt = True;" +
                "TrustServerCertificate = True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);

        }

    }

}