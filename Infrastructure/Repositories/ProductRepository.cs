using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    private readonly DataContext _dataContext;

    public ProductRepository(DataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<Product?> FindByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _dataContext.Products.FindAsync(id, cancellationToken);
    }

    public async Task<List<Product>> GetCompanyWithPaginationAsync(int pageSize, int pageNumber, CancellationToken cancellationToken)
    {
        return await _dataContext.Products
            .OrderBy(b => b.Id)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<Product?> UpdateCompany(Product request)
    {
        var company = await _dataContext.Products.FindAsync(request.Id);
        if (company == null)
        {
            return null;
        }

        company.Name = request.Name;
        company.ImgUri = request.ImgUri;
        company.Price = request.Price;
        await _dataContext.SaveChangesAsync();

        return company;
    }

    public  void Save()
    {
         _dataContext.SaveChanges();
    }
}