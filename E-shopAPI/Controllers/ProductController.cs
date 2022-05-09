using Application.Products.Commands.UpdateProductDescription;
using Application.Products.Queries.GetProductById;
using Application.Products.Queries.GetProducts;
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

    /// <summary>
    /// Get products with paginating.
    /// </summary>
    [MapToApiVersion("2.0")]
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProductsV2([FromQuery] GetProductsQueryV2 query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Get product by ID.
    /// </summary>
    [HttpGet("{ProductId:int}")]
    public async Task<Product> GetProductById([FromRoute] GetProductsByIdQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Update product's description.
    /// </summary>
    [HttpPut("{id:int}/")]
    public async Task<ActionResult> UpdateDescriptionOfProduct(int id, string? description)
    {
        await _sender.Send(new UpdateProductDescriptionCommand { ProductId = id, Description = description });

        return NoContent();
    }
}