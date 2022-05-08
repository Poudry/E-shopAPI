using System.Threading;
using System.Threading.Tasks;
using Application.Products.Queries.GetProducts;
using Domain.Interfaces.Repositories;
using Moq;
using NUnit.Framework;

namespace Application.UnitTests.Products.Queries.GetProductsQuery;

public class GetProductsQueryTest
{
    private Mock<IProductRepository> _productRepository = null!;

    [SetUp]
    public void Setup()
    {
        _productRepository = new Mock<IProductRepository>();
    }

    [Test]
    public async Task ShouldCallRepositoryAndReturnProducts()
    {
        var handler = new GetProductsQueryHandler(_productRepository.Object);
        var query = new Application.Products.Queries.GetProducts.GetProductsQuery();

        await handler.Handle(query, new CancellationToken());

        _productRepository.Verify(
            x => x.GetProducts(new CancellationToken()),
            Times.Once);
    }
}