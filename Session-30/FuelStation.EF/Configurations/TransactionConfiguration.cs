using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {

    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {

        public void Configure(EntityTypeBuilder<Transaction> builder) {

            builder.ToTable("Transactions");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.PaymentMethod).IsRequired();
            builder.Property(t => t.TotalValue).IsRequired().HasPrecision(10, 2);
            builder.HasOne(t => t.Customer).WithMany(t => t.Transactions).HasForeignKey(t => t.CustomerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Employee).WithMany(t => t.Transactions).HasForeignKey(t => t.EmployeeId).OnDelete(DeleteBehavior.Restrict);

        }

    }

}