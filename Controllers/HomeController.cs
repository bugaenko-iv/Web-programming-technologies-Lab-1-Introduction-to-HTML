using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_programming_technologies__Lab_1_Introduction_to_HTML_.Models;

namespace Web_programming_technologies__Lab_1_Introduction_to_HTML_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
