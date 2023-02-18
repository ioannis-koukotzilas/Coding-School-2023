using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {

        public void Configure(EntityTypeBuilder<Employee> builder) {

            

        }

    }

}