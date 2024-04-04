using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Web.Helpers;

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
       
        
        public IActionResult uporabnik()
		{
			Uporabnik uporabnik = new(
				(string?)TempData.Peek("name") ?? string.Empty,
	(string?)TempData.Peek("surname") ?? string.Empty,
	(DateTime?)TempData.Peek("birthdate") ?? DateTime.MinValue,
	(string?)TempData.Peek("email") ?? string.Empty);

            return View(uporabnik);
		}

        public IActionResult slikaPost(Slika model)
        {
            TempData["Slika"] = JsonSerializer.Serialize(model);
            TempData.Keep();

            return RedirectToAction("slika");
        }
        public IActionResult slika()
        {
            Slika slika = JsonSerializer.Deserialize<Slika>((string)TempData.Peek("Slika"));

            return View(slika);
        }

        [HttpPost]
        public IActionResult racunPost(Racun model)
        {
            TempData["Racun"] = JsonSerializer.Serialize(model);
            TempData.Keep();

            return RedirectToAction("racun");
        }
        public IActionResult racun()
        {

            Racun racun = JsonSerializer.Deserialize<Racun>((string)TempData.Peek("Racun"));

            return View("racun", racun);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
