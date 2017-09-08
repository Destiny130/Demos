using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Result()
        {
            IEnumerable<Product> cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product{Name="Kayak",Category="Watersports",Price=275M },
                    new Product {Name = "Lifejacket",Category="Watersports", Price = 48.95M},
                    new Product {Name = "Soccer ball",Category="Soccer", Price = 19.50M},
                    new Product {Name = "Corner flag",Category="Soccer", Price = 34.95M}
                }
            };

            decimal total = 0;
            foreach (Product prod in cart.FilterByCategory("Soccer"))
            {
                total += prod.Price;
            }
            return View((object)string.Format("Cart Total: {0:c}", total));
        }
    }
}