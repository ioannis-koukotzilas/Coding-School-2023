using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ORM.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {

        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.ToTable("Products");
            builder.HasKey(product => product.ID);
            builder.Property(product => product.Code).HasMaxLength(10);
            builder.Property(product => product.Price).HasColumnType("decimal(18,2)");
            builder.Property(product => product.Cost).HasColumnType("decimal(18,2)");

        }

    }
}
