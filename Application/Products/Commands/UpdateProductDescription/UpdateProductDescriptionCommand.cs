using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Products.Commands.UpdateProductDescription;

public class UpdateProductDescriptionCommand : IRequest<Unit>
{
    public int ProductId { get; set; }
    public string? Description { get; set; }
}

public class UpdateProductDescriptionCommandHandler : IRequestHandler<UpdateProductDescriptionCommand, Unit>
{
    private readonly IProductRepository _productRepository;

    public UpdateProductDescriptionCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Unit> Handle(UpdateProductDescriptionCommand request, CancellationToken cancellationToken)
    {
        return await _productRepository.UpdateProductDescriptionAsync(request.ProductId, request.Description,
            cancellationToken);
    }
}