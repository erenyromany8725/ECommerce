using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Name)
             .IsRequired()
             .HasMaxLength(200);

        builder.HasIndex(x => x.Name);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(2000);


        builder.Property(x => x.PhotoUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.Price)
            .HasPrecision(18, 2);

        builder.HasIndex(x => x.Price);

        builder.HasOne(x => x.ProductBrand)
            .WithMany()
            .HasForeignKey(x => x.ProductBrandId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.ProductType)
          .WithMany()
          .HasForeignKey(x => x.ProductTypeId)
          .OnDelete(DeleteBehavior.NoAction);
    }
}
