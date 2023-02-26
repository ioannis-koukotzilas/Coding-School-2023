using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {

    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {

        public void Configure(EntityTypeBuilder<TransactionLine> builder) {

            builder.ToTable("TransactionLines");
            builder.HasKey(tl => tl.Id);
            builder.Property(tl => tl.Id).ValueGeneratedOnAdd();
            builder.Property(tl => tl.Quantity).IsRequired();
            builder.Property(tl => tl.ItemPrice).IsRequired().HasPrecision(10, 2);
            builder.Property(tl => tl.NetValue).IsRequired().HasPrecision(10, 2);
            builder.Property(tl => tl.DiscountPercent).IsRequired().HasPrecision(10, 2);
            builder.Property(tl => tl.DiscountValue).IsRequired().HasPrecision(10, 2);
            builder.Property(tl => tl.TotalValue).IsRequired().HasPrecision(10, 2);
            builder.HasOne(tl => tl.Transaction).WithMany(tl => tl.TransactionLines).HasForeignKey(tl => tl.TransactionId);
            builder.HasOne(tl => tl.Item).WithMany(tl => tl.TransactionLines).HasForeignKey(tl => tl.ItemId).OnDelete(DeleteBehavior.Restrict);

        }

    }

}