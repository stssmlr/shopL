using Microsoft.AspNetCore.Mvc;
using shopL.Data;
using shopL.Models;

namespace shopL.Controllers
{
    public class ProductsController : Controller
    {
        private ShopDbContext ctx = new ShopDbContext();
        public ProductsController()
        {
            
        }
        public IActionResult Index()
        {
            var products = ctx.Products.ToList();
            return View(products);
        }
    }
}
