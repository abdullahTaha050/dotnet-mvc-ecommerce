namespace ecommerce_mvc_tutorial.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public float Price { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    public bool IsHomePage { get; set; }
    public bool IsActive { get; set; }
}
