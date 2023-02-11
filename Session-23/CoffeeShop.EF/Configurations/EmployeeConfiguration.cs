using System;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations {

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {

        public void Configure(EntityTypeBuilder<Employee> builder) {

            // Table Name
            builder.ToTable("Employees");

            // Primary Key
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Surname).HasMaxLength(100).IsRequired();
            builder.Property(e => e.SalaryPerMonth).IsRequired();
            builder.Property(e => e.EmployeeType).IsRequired();

        }

    }

}

