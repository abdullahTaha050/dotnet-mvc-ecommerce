namespace ecommerce_mvc_tutorial.Entities;

public class Category
{
  public int Id { get; set; }
  public string Name { get; set; } = null!;
  public string Url { get; set; } = null!;

//ilişki kuracağımız entity'nin adını vererek bir kategoriye birden fazla ürünün bağlı olabileceğini EF'ye göstermiş olduk.
  public List<Product> Products { get; set; } = new ();

}