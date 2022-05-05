using System.Linq.Expressions;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly DataContext _dataContext;

    public RepositoryBase(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IQueryable<T> FindAll() => _dataContext.Set<T>().AsNoTracking();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
        _dataContext.Set<T>().Where(expression).AsNoTracking();

    public void Create(T entity) => _dataContext.Set<T>().Add(entity);
    public void Update(T entity) => _dataContext.Set<T>().Update(entity);
    public void Delete(T entity) => _dataContext.Set<T>().Remove(entity);
}