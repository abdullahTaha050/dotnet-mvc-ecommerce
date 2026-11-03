using Microsoft.AspNetCore.Mvc;

namespace ecommerce_mvc_tutorial.Controllers;

    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
