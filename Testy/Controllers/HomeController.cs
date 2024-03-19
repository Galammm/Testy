using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testy.Models;

namespace Testy.Controllers
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
        public IActionResult Reg()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Homepage()
        {
            return View();
        }
        public IActionResult Formpage()
        {
            return View();
        }
        public IActionResult Homepage_Admin()
        {
            return View();
        }

        public IActionResult ManageAdmin()
        {
            return View();
        }

        public IActionResult Department_Admin()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Prowait()
        {
            return View();
        }

        public IActionResult Wait()
        {
            return View();
        }

        public IActionResult Editpro()
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
