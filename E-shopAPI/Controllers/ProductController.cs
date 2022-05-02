using E_shopAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_shopAPI.Controllers;

[ApiController]
[ApiVersion("1.0")]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProductController : ControllerBase
{
    private readonly DataContext _dataContext;

    public ProductController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    /// <summary>
    /// Get all products.
    /// </summary>
    [MapToApiVersion("1.0")]
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return Ok(await _dataContext.Products.ToListAsync());
    }

    [MapToApiVersion("2.0")]
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProductsV2()
    {
        return BadRequest(await _dataContext.Products.ToListAsync());
    }

    /// <summary>
    /// Get product by ID.
    /// </summary>
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
    /// <summary>
    /// Update product's description.
    /// </summary>
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