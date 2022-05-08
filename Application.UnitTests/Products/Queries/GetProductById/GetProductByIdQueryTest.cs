using System.Threading;
using System.Threading.Tasks;
using Application.Products.Queries.GetProductById;
using Domain.Interfaces.Repositories;
using Moq;
using NUnit.Framework;

namespace Application.UnitTests.Products.Queries.GetProductById;

public class GetProductByIdQueryTest
{
    private Mock<IProductRepository> _productRepository = null!;

    [SetUp]
    public void Setup()
    {
        _productRepository = new Mock<IProductRepository>();
    }

    [Test]
    public async Task ShouldCallRepositoryAndReturnProduct()
    {
        var handler = new GetProductsByIdQueryHandler(_productRepository.Object);
        var query = new GetProductsByIdQuery
        {
            ProductId = 5
        };

        await handler.Handle(query, new CancellationToken());

        _productRepository.Verify(
            x => x.FindByIdAsync(query.ProductId, new CancellationToken()),
            Times.Once);
    }
}