using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {

        public void Configure(EntityTypeBuilder<Employee> builder) {

            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Surname).IsRequired().HasMaxLength(50);
            builder.Property(e => e.HireDateStart).IsRequired();
            builder.Property(e => e.HireDateEnd).IsRequired();
            builder.Property(e => e.SallaryPerMonth).IsRequired().HasPrecision(10, 2);
            builder.Property(e => e.EmployeeType).IsRequired();

        }

    }

}