using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {

        public void Configure(EntityTypeBuilder<Customer> builder) {

            builder.ToTable("Customers");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength(50);

            builder.Property(c => c.CardNumber).IsRequired().HasMaxLength(30);
            builder.HasIndex(c => c.CardNumber).IsUnique();

        }

    }

}