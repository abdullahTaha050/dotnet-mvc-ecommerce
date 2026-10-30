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

    public IActionResult List()
    {
        var products = _context.Products.ToList();
        return View(products);
    }
}
