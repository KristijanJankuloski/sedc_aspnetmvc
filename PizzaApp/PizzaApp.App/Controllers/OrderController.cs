using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using PizzaApp.Services.Interfaces;
using PizzaApp.ViewModels.OrderViewModels;

namespace PizzaApp.App.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPizzaService _pizzaService;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        public OrderController(IPizzaService pizzaService, IOrderService orderService, IUserService userService)
        {
            _pizzaService = pizzaService;
            _orderService = orderService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.AllUsers = await _userService.GetAllSelectList();
            ViewBag.AllPizzas = await _pizzaService.GetAllForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            await _orderService.CreateOrder(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
