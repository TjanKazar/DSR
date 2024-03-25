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
            TempData.Clear();
            
            return View();
            
        }

        [HttpPost]
        public IActionResult Index(string name, string surname, DateTime birthdate, string emso)
        {
            TempData["name"] = name;
            TempData["surname"] = surname;
            TempData["birthdate"] = birthdate;
            TempData["emso"] = emso;

            if (TempData.Peek("name") == null || TempData.Peek("surname") == null || TempData.Peek("birthdate") == null || TempData.Peek("emso") == null)
            {
                return RedirectToAction("Index");
            }
            TempData.Keep();
            return RedirectToAction("Naslov");
        }

        public IActionResult Naslov()
        {
            if (TempData.Peek("name") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Naslov(string address, int postnum, string post, string country)
        {
            TempData["address"] = address;
            TempData["postnum"] = postnum;
            TempData["post"] = post;
            TempData["country"] = country;

            if (TempData.Peek("address") == null || TempData.Peek("postnum") == null || TempData.Peek("post") == null || TempData.Peek("country") == null)
            {
                return RedirectToAction();
            }
            TempData.Keep();
            return RedirectToAction("Zakljuci");
        }
        public IActionResult Zakljuci()
        {
            if (TempData.Peek("name") == null || TempData.Peek("country") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Zakljuci(string email, string password, string password2)
        {
            TempData["email"] = email;
            TempData["pass1"] = password;
            TempData["pass2"] = password2;
            if (TempData.Peek("email") == null || TempData.Peek("pass1") == null)
            {
                return RedirectToAction("Index");
            }
            TempData.Keep();
            return RedirectToAction("novUporabnik");
        }
        public IActionResult novUporabnik()
        {
            if (TempData.Peek("name") == null || TempData.Peek("country") == null || TempData.Peek("email") == null)
            {
                return RedirectToAction("Index");
            }
            UporabnikModel novUporabnik = new(
    (string?)TempData.Peek("name") ?? string.Empty,
    (string?)TempData.Peek("surname") ?? string.Empty,
    (DateTime?)TempData.Peek("birthdate") ?? DateTime.MinValue,
    (string?)TempData.Peek("emso") ?? string.Empty,
    (string?)TempData.Peek("address") ?? string.Empty,
    (string?)TempData.Peek("email") ?? string.Empty,
    (string?)TempData.Peek("post") ?? string.Empty,
    (int?)TempData.Peek("postnum") ?? 0,
    (string?)TempData.Peek("country") ?? string.Empty,
    (string?)TempData.Peek("pass1") ?? string.Empty
);
            return View(novUporabnik);
        }
    }
}
