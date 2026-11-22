using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class ProductsController : Controller
    {
        public JsonResult GetProduct()
        {
            return new JsonResult(new List<Product>()
            {
                new Product { Id = 1,Name = "P01", Price = 20000 },
                new Product { Id = 2,Name = "P02", Price = 12000 },
                new Product { Id = 3,Name = "P03", Price = 5000 },
            });

        }

        public ViewResult Index()
        {
            return new ViewResult();
        }

        public RedirectResult RedirectToUrl()
        {
            return Redirect("https://www.google.com/");
        }

        public IActionResult Test(int id)
        {
            if (id == 1)
            {
                return View();
            }
            else if (id == 2) {
                return Redirect("https://www.google.com/");
            } else if (id == 3) {
                return Json(new Product() { Id = 1, Name = "Iphone 15 Pro Max", Price = 20 });
            } else
            {
                return NotFound();
            }
        }
    }
}
