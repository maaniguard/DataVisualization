using MediatR;
using System.Threading;
using System.Threading.Tasks;
using DataVisualization.Application.DTOs;
using DataVisualization.Application.Queries;
using DataVisualization.Core.Interfaces;

namespace DataVisualization.Application.Handlers
{
    public class GetSalesDataByIdHandler : IRequestHandler<GetSalesDataByIdQuery, SalesDataDto>
    {
        private readonly ISalesDataRepository _repository;

        public GetSalesDataByIdHandler(ISalesDataRepository repository)
        {
            _repository = repository;
        }

        public async Task<SalesDataDto> Handle(GetSalesDataByIdQuery request, CancellationToken cancellationToken)
        {
            var salesData = await _repository.GetByIdAsync(request.Id);

            if (salesData == null)
                return null;

            return new SalesDataDto
            {
                Id = salesData.Id,
                Product = salesData.Product,
                Region = salesData.Region,
                Date = salesData.Date,
                Amount = salesData.Amount,
                Units = salesData.Units
            };
        }
    }
}