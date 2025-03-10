using DataVisualization.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using DataVisualization.Application.DTOs;

namespace DataVisualization.Application.Queries
{
    public class GetAllSalesDataQuery : IRequest<IEnumerable<SalesDataDto>>
    {

    }
    
}
