using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DSR_KAZAR_N1.Controllers
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
        public IActionResult Slike()
        {
            Slika slika = new(0, "Drawing", 99.99m, 2001, true);
            ViewBag.Slika = slika;
            return View();
        }

        public IActionResult Uporabniki()
        {
            DateTime dateTime = new DateTime(2001, 12, 31);
                List < Racun > racuni = new();
            Uporabnik uporabnik = new("Janez", "Novak", dateTime, "janez.novak@test.com", racuni);
            ViewBag.Uporabnik = uporabnik;
            return View();
        }
        public IActionResult Racuni()
        {
            DateTime datumIzdaje = new DateTime(2024, 3, 14); 
            List<Slika> nakupList = new List<Slika>(); 
            decimal cenaSkupaj = 100.50m; 

            Racun racun = new Racun(datumIzdaje, nakupList, cenaSkupaj);
            ViewBag.Racun = racun;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
