using System;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations {

    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {

        public void Configure(EntityTypeBuilder<Transaction> builder) {

            // Table Name
            builder.ToTable("Transactions");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Date).IsRequired();
            builder.Property(t => t.TotalPrice).HasPrecision(9, 2).IsRequired();
            builder.Property(t => t.PaymentMethod).IsRequired();


        }

    }

}

