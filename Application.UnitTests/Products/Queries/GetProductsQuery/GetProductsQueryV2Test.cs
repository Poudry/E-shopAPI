using System.Threading;
using System.Threading.Tasks;
using Application.Products.Queries.GetProducts;
using Domain.Interfaces.Repositories;
using Moq;
using NUnit.Framework;

namespace Application.UnitTests.Products.Queries.GetProductsQuery;

public class GetProductsQueryV2Test
{
    private Mock<IProductRepository> _productRepository = null!;

    [SetUp]
    public void Setup()
    {
        _productRepository = new Mock<IProductRepository>();
    }

    [Test]
    public async Task ShouldCallRepositoryAndReturnProductsWithPagination()
    {
        var handler = new GetProductsQueryV2Handler(_productRepository.Object);
        var query = new GetProductsQueryV2();

        await handler.Handle(query, new CancellationToken());

        _productRepository.Verify(
            x => x.GetProductsWithPaginationAsync(query.PageSize, query.PageNumber, new CancellationToken()),
            Times.Once);
    }
}