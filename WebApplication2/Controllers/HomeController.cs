using AntiforgeryTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AntiforgeryTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Create(City city)
        {
            return "Success";
        }
    }
}