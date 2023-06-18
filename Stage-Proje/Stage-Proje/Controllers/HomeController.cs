using Microsoft.AspNetCore.Mvc;
using Stage_Proje.Models;
using System.Diagnostics;

namespace Stage_Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult hakkimizda()
        {
            return View();
        }
        public IActionResult musteriaydinlatmametni()
        {
            return View();
        }
        public IActionResult sikcasorlansorular()
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