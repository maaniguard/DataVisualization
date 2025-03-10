using DataVisualization.Core.Interfaces;
using DataVisualization.Core.Models;
using DataVisualization.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVisualization.Infrastructure.Repositories
{
    public class SalesDataRepository : Repository<SalesData>, ISalesDataRepository
    {
        public SalesDataRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SalesData>> GetSalesByRegionAsync(string region)
        {
            return await _context.SalesData
                .Where(s => s.Region == region)
                .ToListAsync();
        }

        public async Task<IEnumerable<SalesData>> GetSalesByProductAsync(string product)
        {
            return await _context.SalesData
                .Where(s => s.Product == product)
                .ToListAsync();
        }
    }
}
