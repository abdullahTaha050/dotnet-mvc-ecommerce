namespace ecommerce_mvc_tutorial.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public float Price { get; set; }
    public bool IsActive { get; set; }
}
