using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecommerce_mvc_tutorial.Models;
using ecommerce_mvc_tutorial.Context;

namespace ecommerce_mvc_tutorial.Controllers;

public class HomeController : Controller
{
     private readonly DataContext _context;

    public HomeController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.Where(p => p.IsHomePage && p.IsActive).ToList();
        return View(products);
    }
}
