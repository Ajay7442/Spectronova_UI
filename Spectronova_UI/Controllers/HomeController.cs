using Microsoft.AspNetCore.Mvc;
using Spectronova_UI.Models;
using System.Diagnostics;

namespace Spectronova_UI.Controllers
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

    }
}
