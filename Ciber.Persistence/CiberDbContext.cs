using Ciber.Application.Common.Interfaces;
using Ciber.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber.Persistence
{
    public class CiberDbContext: DbContext, ICiberDbContext
    {
        public CiberDbContext(DbContextOptions<CiberDbContext> options)
           : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
