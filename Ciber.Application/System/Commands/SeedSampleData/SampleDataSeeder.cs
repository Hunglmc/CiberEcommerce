using Ciber.Application.Common.Interfaces;
using Ciber.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber.Application.System.Commands.SeedSampleData
{
    public class SampleDataSeeder
    {

        private readonly ICiberDbContext _context;
        private readonly IUserManager _userManager;

        private readonly Dictionary<int, Category> Categories = new Dictionary<int, Category>();
        public SampleDataSeeder(ICiberDbContext context, IUserManager userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task SeedAllAsync(CancellationToken cancellationToken)
        {
            await SeedCategoriesAsync(cancellationToken);
        }
        

        private async Task SeedCategoriesAsync(CancellationToken cancellationToken)
        {
            Categories.Add(1, new Category
            {
                CategoryName = "Beverages",
                CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
            });

            Categories.Add(2, new Category
            {
                CategoryName = "Condiments",
                CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
            });

            Categories.Add(3, new Category
            {
                CategoryName = "Confections",
                CategoryDescription = "Desserts, candies, and sweet breads",
            });

            Categories.Add(4, new Category
            {
                CategoryName = "Dairy Products",
                CategoryDescription = "Cheeses",

            });

            Categories.Add(5, new Category
            {
                CategoryName = "Grains/Cereals",
                CategoryDescription = "Breads, crackers, pasta, and cereal",
            });

            Categories.Add(6, new Category
            {
                CategoryName = "Meat/Poultry",
                CategoryDescription = "Prepared meats",
            });

            Categories.Add(7, new Category
            {
                CategoryName = "Produce",
                CategoryDescription = "Dried fruit and bean curd"
            });
            Categories.Add(8, new Category
            {
                CategoryName = "Seafood",
                CategoryDescription = "Seaweed and fish",

            });
            foreach (var category in Categories.Values)
            {
                _context.Categories.Add(category);
            }
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
