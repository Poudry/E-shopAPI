using Domain.Entities;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Products.Queries.GetProducts;

public class GetProductsQueryV2 : IRequest<List<Product>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetProductsQueryV2Handler : IRequestHandler<GetProductsQueryV2, List<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryV2Handler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> Handle(GetProductsQueryV2 request, CancellationToken cancellationToken)
    {
        return await _productRepository.GetProductsWithPaginationAsync(request.PageSize, request.PageNumber,
            cancellationToken);
    }
}