using System;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations {

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {

        public void Configure(EntityTypeBuilder<Customer> builder) {

            // Table Name
            builder.ToTable("Customers");

            // Primary Key
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(c => c.Code).HasMaxLength(20).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(150).IsRequired();

        }

    }

}