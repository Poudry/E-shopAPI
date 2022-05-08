using Domain.Entities;
using MediatR;

namespace Domain.Interfaces.Repositories;

public interface IProductRepository : IRepositoryBase<Product>
{
    public Task<Product> FindByIdAsync(int id, CancellationToken cancellationToken);
    public Task<List<Product>> GetProductsWithPaginationAsync(int pageSize, int pageNumber,  CancellationToken cancellationToken);
    public Task<Unit> UpdateProductDescriptionAsync(int id, string? description, CancellationToken cancellationToken);
    public void Save();

}