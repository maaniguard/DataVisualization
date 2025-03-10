using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVisualization.Core.Models
{
    public class SalesData
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Region { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int Units { get; set; }
    }
}
