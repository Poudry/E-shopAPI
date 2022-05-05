using Application.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product = Domain.Entities.Product;

namespace E_shopAPI.Controllers;

[ApiController]
[ApiVersion("1.0")]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ISender _sender;

    public ProductController(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Get all products.
    /// </summary>
    [MapToApiVersion("1.0")]
    [HttpGet]
    public async Task<List<Product>> GetProducts()
    {
        return await _sender.Send(new GetProductsQuery());
    }

    // /// <summary>
    // /// Get products with paginating.
    // /// </summary>
    // [MapToApiVersion("2.0")]
    // [HttpGet]
    // public async Task<ActionResult<List<Product>>> GetProductsV2(int pageSize = 10, int page = 1)
    // {
    //     return Ok(await _dataContext.Products
    //         .OrderBy(b => b.Id)
    //         .Skip(pageSize * (page - 1))
    //         .Take(pageSize)
    //         .ToListAsync());
    // }

    // /// <summary>
    // /// Get product by ID.
    // /// </summary>
    // [HttpGet("{id:int}")]
    // public async Task<int> GetProductById(int id)
    // {
    //     return await _sender.Send(new CreateCompanyCommand());
    //
    //     // try
    //     // {
    //     //     Product product = await _dataContext.Products.FindAsync(id) ?? throw new Exception();
    //     //     return Ok(product);
    //     // }
    //     // catch (Exception)
    //     // {
    //     //     return BadRequest("Product not found.");
    //     // }
    // }

    // /// <summary>
    // /// Update product's description.
    // /// </summary>
    // [HttpPut("{id:int}/")]
    // public async Task<ActionResult<Product>> UpdateDescriptionOfProduct(int id, string? description)
    // {
    //     try
    //     {
    //         Product product = await _dataContext.Products.FindAsync(id) ?? throw new Exception();
    //         product.Description = description;
    //         await _dataContext.SaveChangesAsync();
    //
    //         return Ok(product);
    //     }
    //     catch (Exception)
    //     {
    //         return BadRequest("Product not found.");
    //     }
    // }
}