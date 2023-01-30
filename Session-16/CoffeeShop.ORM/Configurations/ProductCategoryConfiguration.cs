using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ORM.Configurations {

    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory> {

        public void Configure(EntityTypeBuilder<ProductCategory> builder) {

            builder.ToTable("Product.Category");
            builder.HasKey(productCategory => productCategory.ID);

        }

    }

}
