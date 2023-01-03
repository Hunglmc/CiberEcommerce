using Ciber.Application.Common.Interfaces;
using Ciber.Domain.Common;
using Ciber.Domain.Entities;
using Ciber.Comon;
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
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        public CiberDbContext(DbContextOptions<CiberDbContext> options)
           : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }    

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CiberDbContext).Assembly);
        }


    }
}
