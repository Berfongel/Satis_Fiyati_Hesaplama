using AlisFiyatiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AlisFiyatiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(AlisFiyati alisFiyati)
        {

            var alis_fiyati = alisFiyati.AlisFiyat;
            var vergi_orani = alisFiyati.VergiOrani;
            var kar_orani = alisFiyati.KarOrani;
            var satis_fiyati = alis_fiyati + (vergi_orani*alis_fiyati)/100 + (kar_orani*alis_fiyati)/100;
            ViewBag.Message ="Satış Fiyatı : " + satis_fiyati;

            return View("alisFiyati");
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