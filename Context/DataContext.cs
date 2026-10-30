using ecommerce_mvc_tutorial.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_mvc_tutorial.Context;

/* 
  Burada bulunan DbSet bir nevi List görevi görür. 
  Fakat EF tarafında özelleşmeleri olduğu için direkt List değildir. 
*/

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options)
  {

  }  


  public DbSet<Product> Products { get; set; }
}