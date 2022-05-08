using Application.Common.Exceptions;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    private readonly DataContext _dataContext;

    public ProductRepository(DataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<List<Product>> GetProducts(CancellationToken cancellationToken)
    {
        return await FindAll().ToListAsync(cancellationToken);
    }

    public async Task<Product> FindByIdAsync(int id, CancellationToken cancellationToken)
    {
        var product = await _dataContext.Products.FindAsync(id);

        if (product is null)
        {
            throw new NotFoundException(nameof(Product), id);
        }

        return product;
    }

    public async Task<List<Product>> GetProductsWithPaginationAsync(int pageSize, int pageNumber,
        CancellationToken cancellationToken)
    {
        return await _dataContext.Products
            .OrderBy(b => b.Id)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<Unit> UpdateProductDescriptionAsync(int id, string? description,
        CancellationToken cancellationToken)
    {
        var product = await FindByIdAsync(id, cancellationToken);

        product.Description = description;
        await _dataContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }

    public void Save()
    {
        _dataContext.SaveChanges();
    }
}