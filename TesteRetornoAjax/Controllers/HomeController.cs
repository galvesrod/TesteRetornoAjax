using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteRetornoAjax.Models;

namespace TesteRetornoAjax.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public JsonResult getData()
        {
            List<ListaTeste> teste = new List<ListaTeste>();
            teste.Add(new ListaTeste { NrAval = 20, NiveisLabel = "Nivel 1" });
            teste.Add(new ListaTeste { NrAval = 15, NiveisLabel = "Nivel 2" });
            teste.Add(new ListaTeste { NrAval = 30, NiveisLabel = "Nivel 3" });
            teste.Add(new ListaTeste { NrAval = 50, NiveisLabel = "Nivel 4" });
            teste.Add(new ListaTeste { NrAval = 70, NiveisLabel = "Nivel 5" });
            return Json(teste);
        }
    }
}
