using Microsoft.AspNetCore.Mvc;
using PizzaApp.Data;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDB.Pizzas;
            return View(pizzas);
        }
    }
}
