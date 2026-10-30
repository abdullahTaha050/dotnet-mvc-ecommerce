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

    modelBuilder.Entity<Category>().HasData(
      new List<Category>
      {
        new Category() {Id = 1, Name = "Telefon", Url = "telefon"},
        new Category() {Id = 2, Name = "Beyaz Eşya", Url = "beyaz-esya"},
        new Category() {Id = 3, Name = "Giyim", Url = "giyim"},
        new Category() {Id = 4, Name = "Kozmetik", Url = "kozmetik"},
        new Category() {Id = 5, Name = "Elektronik", Url = "elektronik"},
      }
    );

    modelBuilder.Entity<Product>().HasData(
      new List<Product>()
      {
        new Product() {Id= 1, IsActive= true, Name = "Samsung s10", Price = 20000, Image = "1.jpeg", IsHomePage = true, 
        Description = "Lorem ipsum, dolor sit amet consectetur qor voluptatem explnissimos! Deleniti.", CategoryId = 1},
        new Product() {Id= 2, IsActive= true, Name = "Samsung s14", Price = 30000, Image = "2.jpeg", IsHomePage = false, 
        Description = "Lorem ipsum, dolor sit amet consectetur qor voluptatem explnissimos! Deleniti.", CategoryId = 2},
        new Product() {Id= 3, IsActive= false, Name = "Samsung s32", Price = 60000, Image = "3.jpeg", IsHomePage = true, 
        Description = "Lorem ipsum, dolor sit amet consectetur qor voluptatem explnissimos! Deleniti.", CategoryId = 1}
      }
    );
  }




  public DbSet<Product> Products { get; set; }
}