namespace E_shopAPI;

public class Product
{
    public int Id { get; set; } //req
    public string Name { get; set; } //req
    public Uri ImgUri { get; set; } //req
    public decimal Price { get; set; } //req decimal
    public string? Description { get; set; } //optional
}