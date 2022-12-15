using HealthMonitoring.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthMonitoring.Controllers
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

        public IActionResult Home()
        {
            return View("Home");
        }
        public IActionResult Medicamentos()
        {
            return View("Medicamentos");
        }
        public IActionResult Usuario()
        {
            return View("Usuario");
        }
        public IActionResult Extras()
        {
            return View("Extras");
        }
        public IActionResult Monitoramento()
        {
            return View("Monitoramento");
        }
    }
}