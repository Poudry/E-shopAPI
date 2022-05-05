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

    public async Task<Product?> FindByIdAsync(int id)
    {
        return await _dataContext.Products.FindAsync(id);
    }

    public async Task<List<Product>> GetCompanyWithPaginationAsync(int pageSize, int page)
    {
        return await _dataContext.Products
            .OrderBy(b => b.Id)
            .Skip(pageSize * (page - 1))
            .Take(pageSize)
            .ToListAsync();
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