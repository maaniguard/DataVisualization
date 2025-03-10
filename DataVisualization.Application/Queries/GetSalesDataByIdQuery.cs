using DataVisualization.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVisualization.Application.Queries
{
    public class GetSalesDataByIdQuery : IRequest<SalesDataDto>
    {
        public int Id { get; set; }
    }
}
