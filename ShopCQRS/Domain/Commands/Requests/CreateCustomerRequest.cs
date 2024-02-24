using MediatR;
using ShopCQRS.Domain.Commands.Responses;

namespace ShopCQRS.Domain.Commands.Requests
{

    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
