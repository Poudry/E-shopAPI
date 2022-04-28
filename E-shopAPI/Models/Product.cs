using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_shopAPI.Models;

public class Product
{
    public int Id { get; set; } //req
    [Required] public string Name { get; set; } //req

    [Required] [Url] public Uri ImgUri { get; set; } //req
    public string? Description { get; set; } //optional

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; } //req decimal
}