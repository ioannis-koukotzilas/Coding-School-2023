using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ORM.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {

        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.ToTable("Products");
            builder.HasKey(prod => prod.ID);
            builder.Property(prod => prod.ID).ValueGeneratedOnAdd();
            builder.Property(prod => prod.Code).HasMaxLength(10);
            builder.Property(prod => prod.Price).HasColumnType("decimal(18,2)");
            builder.Property(prod => prod.Cost).HasColumnType("decimal(18,2)");

            builder.HasOne(prod => prod.ProductCategory).
                WithOne(prodCat => prodCat.Product).
                HasForeignKey<Product>(prod => prod.ProductCategoryID);

        }

    }
}
