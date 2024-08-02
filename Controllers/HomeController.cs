using BanVeMayBay.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BanVeMayBay.Controllers
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

        public IActionResult Post1()
        {
            return View();
        }
        public IActionResult Post2()
        {
            return View();
        }
        public IActionResult Post3()
        {
            return View();
        }
        public IActionResult Post4()
        {
            return View();
        }
        public IActionResult Post5()
        {
            return View();
        }
        public IActionResult Post6()
        {
            return View();
        }
        public IActionResult Post7()
        {
            return View();
        }
        public IActionResult Post8()
        {
            return View();
        }
        public IActionResult Post9()
        {
            return View();
        }
        public IActionResult Post10()
        {
            return View();
        }
        public IActionResult Post11()
        {
            return View();
        }
        public IActionResult Post12()
        {
            return View();
        }
        public IActionResult TTT()
        {
            return View();
        }
        public IActionResult PPP()
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