using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopCQRS.Domain.Commands.Requests;
using ShopCQRS.Domain.Commands.Responses;

namespace ShopCQRS.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }   

        [HttpPost]
        public Task<CreateCustomerResponse> Create([FromBody] CreateCustomerRequest command)
        {
            return _mediator.Send(command);
        }
    }
}
