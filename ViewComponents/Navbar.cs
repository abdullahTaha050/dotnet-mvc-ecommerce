using ecommerce_mvc_tutorial.Context;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_mvc_tutorial.ViewComponents;


//Hiçbir controller'a bağlı kalmadan kendi bilgisini tamamen kendisi çekip getirecek. 
//örneğin uygulamadaki navbar her sayfada var, oradaki veriler de db'den geliyor (kategoriler).
// bundan dolayı her defasında db den kategori çekip her controllerda bununla uğraşmamak için bu yapıyı kullanıyoruz.
public class Navbar : ViewComponent
{
  private readonly DataContext _context;

  public Navbar(DataContext context)
  {
    _context = context;
  }


  public IViewComponentResult Invoke()
  {
    return View(_context.Categories.ToList());
  }
}