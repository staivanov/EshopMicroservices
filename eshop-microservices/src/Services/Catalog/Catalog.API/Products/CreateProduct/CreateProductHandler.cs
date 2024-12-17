using Catalog.API.Model;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProducCommandtHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //Create product entity from command object.
            Product product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //Save to the database.



            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
