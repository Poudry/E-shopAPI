using System.Threading;
using System.Threading.Tasks;
using Application.Products.Commands.UpdateProductDescription;
using Domain.Interfaces.Repositories;
using Moq;
using NUnit.Framework;

namespace Application.UnitTests.Products.Commands.UpdateProductDescription;

public class UpdateProductDescriptionCommandTest
{
    private Mock<IProductRepository> _productRepository = null!;

    [SetUp]
    public void Setup()
    {
        _productRepository = new Mock<IProductRepository>();
    }

    [Test]
    public async Task ShouldCallRepositoryAndUpdateProduct()
    {
        var handler = new UpdateProductDescriptionCommandHandler(_productRepository.Object);
        var command = new UpdateProductDescriptionCommand
        {
            ProductId = 5
        };

        await handler.Handle(command, new CancellationToken());

        _productRepository.Verify(
            x => x.UpdateProductDescriptionAsync(command.ProductId, command.Description, new CancellationToken()),
            Times.Once);
    }
}