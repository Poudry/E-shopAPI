using Domain.Entities;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Products.Queries.GetProducts;

public class GetProductsQuery : IRequest<List<Product>>
{
}

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Product>>
{
    private readonly IProductRepository _productRepository;
    
    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.GetProducts(cancellationToken);
    }
}