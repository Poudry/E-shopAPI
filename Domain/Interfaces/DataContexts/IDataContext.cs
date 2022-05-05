using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Interfaces.DataContexts;

public interface IDataContext
{
    public DbSet<Product> Products { get; set; }
}