using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSR_KAZAR_N1.Controllers
{
    public class RegistracijaController : Controller
    {
        public IActionResult Index(UporabnikModel model)
        {

            TempData.Clear();
            
            return View(model);
            
        }

        [HttpPost]
        public IActionResult Index(page1Model model)
        {
            TempData["name"] = model.name;
            TempData["surname"] = model.surname;
            TempData["birthdate"] = model.birthdate;
            TempData["birthplace"] = model.birthplace;
            TempData["emso"] = model.emso;

            if (!ModelState.IsValid)
            {
                Console.WriteLine("in line 29");
                return View(model);
            }
            TempData.Keep();
            return RedirectToAction("Index");
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
        public IActionResult Naslov(page2Model model)
        {
            TempData["address"] = model.address;
            TempData["postnum"] = model.postnum;
            TempData["post"] = model.post;
            TempData["country"] = model.country;

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            TempData.Keep();
            return RedirectToAction("_Zakljuci");
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
        public IActionResult Zakljuci(page3Model model)
        {
            TempData["email"] = model.email;
            TempData["pass1"] = model.password;
            TempData["pass2"] = model.password2;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            TempData.Keep();
            return RedirectToAction("Index");
        }
        public IActionResult novUporabnik()
        {
            UporabnikModel novUporabnik = new(
    (string?)TempData.Peek("name") ?? string.Empty,
    (string?)TempData.Peek("surname") ?? string.Empty,
    (DateTime?)TempData.Peek("birthdate") ?? DateTime.MinValue,
    (string?)TempData.Peek("birthplace") ?? string.Empty,
    (string?)TempData.Peek("emso") ?? string.Empty,
    (string?)TempData.Peek("address") ?? string.Empty,
    (string?)TempData.Peek("post") ?? string.Empty,
    (int?)TempData.Peek("postnum") ?? 0,
    (string?)TempData.Peek("country") ?? string.Empty,
    (string?)TempData.Peek("email") ?? string.Empty,
    (string?)TempData.Peek("pass1") ?? string.Empty
);
            if (TempData.Peek("name") == null || TempData.Peek("country") == null || TempData.Peek("email") == null)
            {
                return RedirectToAction("Index");
            }
            return View(novUporabnik);
        }
    }
}
