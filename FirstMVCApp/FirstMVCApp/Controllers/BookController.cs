using FirstMVCApp.Data;
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            Book book = new Book() { Id = 1, Title = "Lord of the Rings"};
            return View(book);
        }

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Redirect2()
        {
            return RedirectToAction("Index", "Home");
        }

        [Route("json")]
        public IActionResult GetJson()
        {
            return Json(StaticDB.Books.First());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", "Home");
            Book book = StaticDB.Books.FirstOrDefault(x => x.Id == id);
            if(book == null)
                return RedirectToAction("Error", "Home");
            return View(book);
        }
    }
}
