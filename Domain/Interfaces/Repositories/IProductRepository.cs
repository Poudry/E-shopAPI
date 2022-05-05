using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IProductRepository : IRepositoryBase<Product>
{
    public Task<Product?> FindByIdAsync(int id);
    public Task<List<Product>> GetCompanyWithPaginationAsync(int pageSize, int page);
    public Task<Product?> UpdateCompany(Product request);
    public void Save();

}