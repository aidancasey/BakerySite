using Bakery.Models;
using Bakery.Services;
using System.Web.Mvc;

namespace Bakery.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        [Route("order/{id:int}")]
        public ActionResult Index(int id)
        {
            ViewBag.Title = "Place Your Order";
            IProductService service = new ProductService();
            OrderFormModel model = new OrderFormModel {
                Product = service.GetProduct(id)
            };
            return View(model);
        }

        [HttpPost]
        [Route("order/{id:int}")]
        public ActionResult Index(OrderFormModel model) 
        {
            if (ModelState.IsValid) 
            {
                Order order = new Order {
                    Product = model.Product,
                    ShippingAddress = model.OrderShipping,
                    EmailAddress = model.OrderEmail,
                    Quantity = model.OrderQty
                };
                IOrderService service = new OrderService();
                service.ProcessOrder(order);
                return View("Success");
            }
            else 
            {
                if (model.Product.Id > 0) 
                {
                    IProductService service = new ProductService();
                    model = new OrderFormModel {
                        Product = service.GetProduct(model.Product.Id)
                    };
                    return View(model);
                }
                else 
                {
                    return RedirectToRoute("Default");
                }
            }
        }
	}
}