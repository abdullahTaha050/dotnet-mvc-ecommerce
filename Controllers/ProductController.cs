using ecommerce_mvc_tutorial.Context;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_mvc_tutorial.Controllers;

public class ProductController : Controller
{

    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult List(string url, string q)
    {
        var query = _context.Products.Where(i => i.IsActive);

        if (!string.IsNullOrEmpty(url))
        {
            query = query.Where(i => i.Category.Url == url);
        }

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(i => i.Name.ToLower().Contains(q));
        }

        //var products = _context.Products.Where(p => p.IsActive && p.Category.Url == url).ToList();
        return View(query.ToList());
    }

    public IActionResult Details(int id)
    {
        //burada birden fazla yöntem gösterilmiştir. iki yol da doğrudur.
        
        // var product = _context.Products.FirstOrDefault(p => p.Id == id);
        var product = _context.Products.Find(id);

        return View(product);
    }
}
