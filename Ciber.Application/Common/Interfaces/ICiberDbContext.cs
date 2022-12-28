using Ciber.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ciber.Application.Common.Interfaces
{
    public interface ICiberDbContext
    {
        DbSet<Category> Categories { get; set; }

        DbSet<Customer> Customers { get; set; }

        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
    }
}