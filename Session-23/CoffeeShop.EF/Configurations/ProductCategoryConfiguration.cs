using System;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations {

    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory> {

        public void Configure(EntityTypeBuilder<ProductCategory> builder) {

            // Table Name
            builder.ToTable("ProductCategories");

            // Primary Key
            builder.HasKey(pc => pc.Id);
            builder.Property(pc => pc.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(pc => pc.Code).HasMaxLength(20).IsRequired();
            builder.Property(pc => pc.Description).HasMaxLength(200).IsRequired();
            builder.Property(pc => pc.ProductType).IsRequired();
           

        }

    }

}

