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
        public IActionResult uporabnikPost(UporabnikModel model)
        {
			TempData["Uporabnik"] = JsonSerializer.Serialize(model);
            TempData.Keep();

            return RedirectToAction("uporabnik");
        }
     
        public IActionResult uporabnik()
		{
            UporabnikModel Uporabnik = JsonSerializer.Deserialize<UporabnikModel>((string)TempData.Peek("Uporabnik"));

            return View(Uporabnik);
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
	}
}
