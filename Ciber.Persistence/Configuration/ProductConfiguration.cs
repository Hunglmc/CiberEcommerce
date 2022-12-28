using Ciber.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.ProductId).HasColumnName("ProductID");

            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");

            builder.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(e => e.ProductDescription).HasColumnName("Description")
                .HasColumnType("ntext");

            builder.Property(e => e.UnitPrice)
               .HasColumnType("money")
               .HasDefaultValueSql("((0))");


        }
    }
}
