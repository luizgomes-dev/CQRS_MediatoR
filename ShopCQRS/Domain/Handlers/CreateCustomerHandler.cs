using MediatR;
using ShopCQRS.Domain.Commands.Requests;
using ShopCQRS.Domain.Commands.Responses;

namespace ShopCQRS.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // verifica se o cliente já está cadastrado
            // valida os dados
            // insere o cliente
            // envia email de boas vindas

            var result =  new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Luiz Gomes",
                Email = "luiz@mail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
