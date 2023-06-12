using Microsoft.AspNetCore.Mvc;
using PizzaApp.Data;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("/ListOrders")]
        public IActionResult Index()
        {
            return View(StaticDB.Orders);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            ViewData.Add("OrderId", id);
            return View();
        }

        public IActionResult JsonData()
        {
            return new JsonResult(StaticDB.Orders);
        }

        public IActionResult Back()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
