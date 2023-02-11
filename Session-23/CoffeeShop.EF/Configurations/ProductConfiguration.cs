using System;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations {

    public class ProductConfiguration : IEntityTypeConfiguration<Product> {

        public void Configure(EntityTypeBuilder<Product> builder) {

            // Table Name
            builder.ToTable("Products");

            // Primary Key
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(p => p.Code).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(3, 2).IsRequired();
            builder.Property(p => p.Cost).HasPrecision(3, 2).IsRequired();


        }

    }

}