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
            TempData.Clear();
            SlikaModel slika = new("Drawing", 99.99m, 2001, true);
            DateTime datumIzdaje = new DateTime(2024, 3, 14);
            List<SlikaModel> nakupList = new List<SlikaModel>();
            decimal cenaSkupaj = 100.50m;
            Racun racun = new Racun(datumIzdaje, nakupList, cenaSkupaj);
            DateTime dateTime = new DateTime(2001, 12, 31);
            List<Racun> racuni = new();
            UporabnikModel uporabnik = new("Janez", "Novak", dateTime, "janez.novak@test.com", racuni);
            var home = new homeModel
            {
                Slika = slika,
                Uporabnik = uporabnik,
                Racun = racun
            };
            return View(home);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
