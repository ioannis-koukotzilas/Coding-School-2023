﻿using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ORM.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {

        public void Configure(EntityTypeBuilder<Customer> builder) {

            builder.ToTable("Customers");
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).ValueGeneratedOnAdd();

        }

    }
}
