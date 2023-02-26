using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {

    public class ItemConfiguration : IEntityTypeConfiguration<Item> {

        public void Configure(EntityTypeBuilder<Item> builder) {

            builder.ToTable("Items");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Code).IsRequired().HasMaxLength(20);
            builder.HasIndex(i => i.Code).IsUnique();
            builder.Property(i => i.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(i => i.ItemType).IsRequired();
            builder.Property(i => i.Price).IsRequired().HasPrecision(10, 2);
            builder.Property(i => i.Cost).IsRequired().HasPrecision(10, 2);

        }

    }

}