using Domain.Entities;
using Domain.Interfaces.DataContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext, IDataContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;
}