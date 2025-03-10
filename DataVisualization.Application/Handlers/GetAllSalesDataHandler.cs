using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DataVisualization.Application.DTOs;
using DataVisualization.Application.Queries;
using DataVisualization.Core.Interfaces;

namespace DataVisualization.Application.Handlers
{
    public class GetAllSalesDataHandler : IRequestHandler<GetAllSalesDataQuery, IEnumerable<SalesDataDto>>
    {
        private readonly ISalesDataRepository _repository;

        public GetAllSalesDataHandler(ISalesDataRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SalesDataDto>> Handle(GetAllSalesDataQuery request, CancellationToken cancellationToken)
        {
            var salesData = await _repository.GetAllAsync();
            var result = new List<SalesDataDto>();

            foreach (var item in salesData)
            {
                result.Add(new SalesDataDto
                {
                    Id = item.Id,
                    Product = item.Product,
                    Region = item.Region,
                    Date = item.Date,
                    Amount = item.Amount,
                    Units = item.Units
                });
            }

            return result;
        }
    }
}
