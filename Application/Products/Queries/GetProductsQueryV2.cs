using Domain.Entities;
using Domain.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Products.Queries;

public class GetProductsQueryV2 : IRequest<List<Product>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetProductsQueryHandlerV2 : IRequestHandler<GetProductsQueryV2, List<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandlerV2(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> Handle(GetProductsQueryV2 request, CancellationToken cancellationToken)
    {
        return await _productRepository.GetCompanyWithPaginationAsync(request.PageSize, request.PageNumber,
            cancellationToken);
    }
}