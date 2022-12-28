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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.CustomerId)
               .HasColumnName("CustomerID")
               .HasMaxLength(16)
               .ValueGeneratedNever();

            builder.Property(e => e.CustomerName).HasMaxLength(30).IsRequired();

            builder.Property(e=>e.CustomerAddress).HasMaxLength(200).IsRequired();
        }

    }
}
