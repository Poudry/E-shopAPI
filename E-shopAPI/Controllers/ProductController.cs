using E_shopAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_shopAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly DataContext _dataContext;

    public ProductController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return Ok(await _dataContext.Products.ToListAsync());
    }

//TODO v2 with versioning
//     [HttpGet]
//     public async Task<ActionResult<List<Product>>> Get()
//     {
//     }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        try
        {
            Product product = await _dataContext.Products.FindAsync(id) ?? throw new Exception();
            return Ok(product);
        }
        catch (Exception)
        {
            return BadRequest("Product not found.");
        }
    }

    //TODO exceptions
    [HttpPut("{id:int}/")]
    public async Task<ActionResult<Product>> UpdateDescriptionOfProduct(int id, string description)
    {
        try
        {
            Product product = await _dataContext.Products.FindAsync(id) ?? throw new InvalidOperationException();
            product.Description = description;
            await _dataContext.SaveChangesAsync();

            return Ok(product);
        }
        catch (Exception)
        {
            return BadRequest("Product not found.");
        }
    }
}