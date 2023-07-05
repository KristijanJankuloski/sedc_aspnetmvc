using Microsoft.AspNetCore.Mvc;
using PizzaApp.Services.Interfaces;

namespace PizzaApp.App.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
