using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Item");

        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Product)
               .WithMany(x => x.Items)
               .HasForeignKey(x => x.ProductId);

        builder.Property(x => x.Quantity)
               .IsRequired();
    }
}