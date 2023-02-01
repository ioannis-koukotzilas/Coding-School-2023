using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ORM.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {

        public void Configure(EntityTypeBuilder<Transaction> builder) {

            builder.ToTable("Transaction");
            builder.HasKey(trans => trans.ID);
            builder.Property(trans => trans.ID).ValueGeneratedOnAdd();
            builder.Property(trans => trans.TotalPrice).HasColumnType("decimal(18,2)");

            builder.HasOne(trans => trans.Customer).
                WithOne(cust => cust.Transaction).
                HasForeignKey<Transaction>(trans => trans.CustomerID);

            builder.HasOne(trans => trans.Employee).
              WithOne(cust => cust.Transaction).
              HasForeignKey<Transaction>(trans => trans.EmployeeID);

        }

    }
}
