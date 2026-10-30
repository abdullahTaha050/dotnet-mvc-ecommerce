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

 // Burası seeder işine yarayan kısım. migration oluşurken bu metot çağırılır. 
 // Biz de override ederek burada seed etmek istediğimiz veriyi ekliyoruz. 
 // Buranın tetiklenmesi için pending olan, db'ye henüz iletilmemiş migrationlar olmalı. yoksa tetiklenmez.
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Product>().HasData(
      new List<Product>()
      {
        new Product() {Id= 1, IsActive= true, Name = "Samsung s10", Price = 20000},
        new Product() {Id= 2, IsActive= true, Name = "Samsung s14", Price = 30000},
        new Product() {Id= 3, IsActive= false, Name = "Samsung s32", Price = 60000}
      }
    );
  }


  public DbSet<Product> Products { get; set; }
}