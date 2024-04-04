using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

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
			return View();
		}

		[HttpPost]
        public IActionResult uporabnikPost(Uporabnik model)
        {
			TempData["name"] = model.name;
			TempData["surname"] = model.surname;
			TempData["birthdate"] = model.birthdate;
			TempData["email"] = model.email;
            TempData.Keep();

            return RedirectToAction("uporabnik", model);
        }
        [HttpPost]
        public IActionResult slikaPost(Slika model)
        {
			TempData["ime"] = model.ime;
			TempData["cena"] = model.cena;
            TempData["letoIzdaje"] = model.letoIzdaje;
			TempData["jeUnikat"] = model.jeUnikat;
            TempData.Keep();

            return RedirectToAction("slika", model);
        }
        [HttpPost]
        public IActionResult racunPost(Racun model)
        {
            TempData["datumIzdaje"] = model.datumIzdaje;
            TempData["cenaSkupaj"] = model.cenaSkupaj;
            TempData.Keep();

            return RedirectToAction("racun", model);
        }

        public IActionResult uporabnik()
		{
			Uporabnik uporabnik = new(
				(string?)TempData.Peek("name") ?? string.Empty,
	(string?)TempData.Peek("surname") ?? string.Empty,
	(DateTime?)TempData.Peek("birthdate") ?? DateTime.MinValue,
	(string?)TempData.Peek("email") ?? string.Empty);

            return View(uporabnik);
		}

        public IActionResult slika()
        {
            Slika slika = new Slika(
                TempData["ime"] as string ?? string.Empty,
                (double)(TempData["cena"] ?? 0),
                (int)(TempData["letoIzdaje"] ?? 0),
                (bool)(TempData["jeUnikat"] ?? false)
            );

            return View(slika);
        }


        public IActionResult racun()
        {
            DateTime datumIzdaje = (DateTime)(TempData["datumIzdaje"] ?? DateTime.MinValue);
            double cenaSkupaj = (double)(TempData["cenaSkupaj"] ?? 0);

            Racun racun = new Racun(datumIzdaje, cenaSkupaj);

            return View("racun", racun);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
