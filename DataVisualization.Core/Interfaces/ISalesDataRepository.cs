using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataVisualization.Core.Models;

namespace DataVisualization.Core.Interfaces
{
    public interface ISalesDataRepository : IRepository<SalesData>
    {
        Task<IEnumerable<SalesData>> GetSalesByRegionAsync(string region);
        Task<IEnumerable<SalesData>> GetSalesByProductAsync(string product);
    }
}
