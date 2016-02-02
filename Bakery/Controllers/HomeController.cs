using Bakery.Models;
using Bakery.Services;
using System;
using System.Web.Mvc;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            IProductService service = new ProductService();
            HomeViewModel model = new HomeViewModel
            {
                Products = service.GetProducts()
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
    }
}