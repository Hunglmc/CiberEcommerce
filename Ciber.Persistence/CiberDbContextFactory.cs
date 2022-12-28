using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciber.Persistence
{
    public class CiberDbContextFactory : DesignTimeDbContextFactoryBase<CiberDbContext>
    {
        protected override CiberDbContext CreateNewInstance(DbContextOptions<CiberDbContext> options)
        {
            return new CiberDbContext(options);
        }
    }
}
