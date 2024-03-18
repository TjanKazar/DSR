using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Xml.Linq;

namespace DSR_KAZAR_N1.Controllers
{
    public class RegistracijaController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Naslov()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Naslov(string name, string surname, DateTime birthdate, string emso)
        {
            TempData["name"] = name;
            TempData["surname"] = surname;
            TempData["birthdate"] = birthdate;
            TempData["emso"] = emso;

            TempData.Keep();
            return View();
        }
        public IActionResult Zakljuci()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Zakljuci(string address, int postnum, string post, string country)
        {
            TempData["address"] = address;
            TempData["postnum"] = postnum;
            TempData["post"] = post;
            TempData["country"] = country;
            TempData.Keep();
            return View();
        }

        public IActionResult novUporabnik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult novUporabnik(string email, string pass1, string pass2)
        {
            TempData["email"] = email;
            TempData["pass1"] = pass1;
            TempData["pass2"] = pass2;
            TempData.Keep();
            UporabnikModel novUporabnik = new((string)TempData.Peek("name"), (string)TempData.Peek("surname"), (DateTime)TempData.Peek("birthdate"), (string)TempData.Peek("emso"), (string)TempData.Peek("address"), (string)TempData.Peek("email"), (string)TempData.Peek("post"), (int)TempData.Peek("postnum"), (string)TempData.Peek("country"), (string)TempData.Peek("password"));
            TempData.Keep();

            return View(novUporabnik);
        }

    }
}
