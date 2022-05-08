using Domain.Entities;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Products.Queries.GetProductById;

public class GetProductsByIdQuery : IRequest<Product>
{
    public int ProductId { get; set; }
}

public class GetProductsByIdQueryHandler : IRequestHandler<GetProductsByIdQuery, Product>
{
    private readonly IProductRepository _productRepository;

    public GetProductsByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> Handle(GetProductsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.FindByIdAsync(request.ProductId, cancellationToken);
    }
}