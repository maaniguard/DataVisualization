using DataVisualization.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DataVisualization.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<SalesData> SalesData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<SalesData>().HasData(
                new SalesData { Id = 1, Product = "Laptop", Region = "North", Date = new DateTime(2025, 1, 15), Amount = 1200.50m, Units = 5 },
                new SalesData { Id = 2, Product = "Smartphone", Region = "South", Date = new DateTime(2025, 1, 20), Amount = 800.25m, Units = 10 },
                new SalesData { Id = 3, Product = "Laptop", Region = "East", Date = new DateTime(2025, 1, 25), Amount = 2400.75m, Units = 8 },
                new SalesData { Id = 4, Product = "Tablet", Region = "West", Date = new DateTime(2025, 2, 5), Amount = 650.00m, Units = 7 },
                new SalesData { Id = 5, Product = "Desktop", Region = "North", Date = new DateTime(2025, 2, 10), Amount = 950.50m, Units = 3 },
                new SalesData { Id = 6, Product = "Smartphone", Region = "East", Date = new DateTime(2025, 2, 15), Amount = 1600.75m, Units = 20 },
                new SalesData { Id = 7, Product = "Tablet", Region = "South", Date = new DateTime(2025, 2, 20), Amount = 975.25m, Units = 12 },
                new SalesData { Id = 8, Product = "Desktop", Region = "West", Date = new DateTime(2025, 3, 1), Amount = 1900.00m, Units = 6 }
            );
        }
    }
}