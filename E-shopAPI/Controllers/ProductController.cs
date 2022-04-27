using Microsoft.AspNetCore.Mvc;

namespace E_shopAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private List<Product> _products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Name = "GUNNAR Gaming Collection RPG designed by Razer, onyx/yellow",
            Price = 1499,
            ImgUri = new Uri("https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=JD610m3a")
        },
        new Product
        {
            Id = 2,
            Name = "ASUS ROG STRIX FLARE II ANIMATE (PBT/NXRD) - US",
            Price = 4999,
            ImgUri = new Uri("https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=NA706q4g"),
            Description = "too much for a keyboard",
        },
    };

    //TODO add logic
    [HttpGet]
    public async Task<ActionResult<List<Product>>> Get()
    {
        return Ok(_products);
    }

//TODO v2 with versoning
//     [HttpGet]
//     public async Task<ActionResult<List<Product>>> Get()
//     {
//     }

    //TODO add logic
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> Get(int id)
    {
        try
        {
            Product product = _products.Find(product1 => product1.Id == id) ?? throw new InvalidOperationException();
            return Ok(product);
        }
        catch (Exception)
        {
            return BadRequest("Product not found.");
        }
    }

    //TODO add logic
    [HttpPut("{id:int}/")]
    public async Task<ActionResult<Product>> UpdateDescription(int id, string description)
    {
        try
        {
            Product product = _products.Find(product1 => product1.Id == id) ?? throw new InvalidOperationException();
            product.Description = description; 
            
            return Ok(_products);
            
        }
        catch (Exception)
        {
            return BadRequest("Product not found.");
        }
    }
}