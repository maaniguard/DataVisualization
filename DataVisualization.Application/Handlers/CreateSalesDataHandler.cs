using MediatR;
using System.Threading;
using System.Threading.Tasks;
using DataVisualization.Application.Commands;
using DataVisualization.Application.DTOs;
using DataVisualization.Core.Interfaces;
using DataVisualization.Core.Models;

namespace DataVisualization.Application.Handlers
{
    public class CreateSalesDataHandler : IRequestHandler<CreateSalesDataCommand, SalesDataDto>
    {
        private readonly ISalesDataRepository _repository;

        public CreateSalesDataHandler(ISalesDataRepository repository)
        {
            _repository = repository;
        }

        public async Task<SalesDataDto> Handle(CreateSalesDataCommand request, CancellationToken cancellationToken)
        {
            var newSalesData = new SalesData
            {
                Product = request.Product,
                Region = request.Region,
                Date = request.Date,
                Amount = request.Amount,
                Units = request.Units
            };

            var result = await _repository.AddAsync(newSalesData);

            return new SalesDataDto
            {
                Id = result.Id,
                Product = result.Product,
                Region = result.Region,
                Date = result.Date,
                Amount = result.Amount,
                Units = result.Units
            };
        }
    }
}