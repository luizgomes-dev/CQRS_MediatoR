using MediatR;
using ShopCQRS.Domain.Commands.Requests;

namespace ShopCQRS.Domain.Commands.Responses
{
    public class CreateCustomerResponse : IRequest<string>
    {

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime Date { get; set; }
    }
}
