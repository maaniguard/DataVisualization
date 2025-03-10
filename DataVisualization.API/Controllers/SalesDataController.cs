using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataVisualization.Application.Commands;
using DataVisualization.Application.DTOs;
using DataVisualization.Application.Queries;

namespace DataVisualization.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SalesDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesDataDto>>> GetAll()
        {
            var query = new GetAllSalesDataQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesDataDto>> GetById(int id)
        {
            var query = new GetSalesDataByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SalesDataDto>> Create(CreateSalesDataCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
    }
}