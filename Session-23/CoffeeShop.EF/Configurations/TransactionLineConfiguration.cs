﻿using System;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations {

    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {

        public void Configure(EntityTypeBuilder<TransactionLine> builder) {

            // Table Name
            builder.ToTable("TransactionLines");

            // Primary Key
            builder.HasKey(tl => tl.Id);
            builder.Property(tl => tl.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(tl => tl.Quantity).IsRequired();
            builder.Property(tl => tl.Discount).HasPrecision(3, 2).IsRequired();
            builder.Property(tl => tl.Price).HasPrecision(3, 2).IsRequired();
            builder.Property(tl => tl.TotalPrice).HasPrecision(9, 2).IsRequired();

            // Relation: TransactionLine includes the TransactionId
            builder.HasOne(t => t.Transaction)
                .WithMany(t => t.TransactionLines)
                .HasForeignKey(t => t.TransactionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relation: TransactionLine includes the ProductId
            builder.HasOne(t => t.Product)
                .WithMany(t => t.TransactionLines)
                .HasForeignKey(t => t.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }

}