using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IProductRepository : IRepositoryBase<Product>
{
    public Task<Product?> FindByIdAsync(int id, CancellationToken cancellationToken);
    public Task<List<Product>> GetCompanyWithPaginationAsync(int pageSize, int pageNumber,  CancellationToken cancellationToken);
    public Task<Product?> UpdateCompany(Product request);
    public void Save();

}