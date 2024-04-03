using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DSR_KAZAR_N1.Controllers
{
    public class RegistracijaController : Controller
    {
        public IActionResult Index()
        {
            //TempData.Clear();
            ViewBag.lokacije = new SelectList(lokacije.GetLokacije(), "Id", "lokacija");
            return View();

        }

        [HttpPost]
        public IActionResult Index(UporabnikModel model)
        {
            TempData["name"] = model.name;
            TempData["surname"] = model.surname;
            TempData["birthdate"] = model.birthdate;
            TempData["birthplace"] = model.birthplace;
            TempData["emso"] = model.emso;
            TempData["address"] = model.address;
            TempData["postnum"] = model.postnum;
            TempData["post"] = model.post;
            TempData["country"] = model.country;
            TempData["email"] = model.email;
            TempData["pass1"] = model.password;
            TempData["pass2"] = model.password2;
            TempData.Keep();
            ModelState.Remove("receipts");
            if (!ModelState.IsValid)
            {
                foreach (var key in TempData.Keys)
                {
                    Console.WriteLine($"{key}: {TempData[key]}");
                }
                return View(model);
            }
            return RedirectToAction("novUporabnik");
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
    (string?)TempData.Peek("pass1") ?? string.Empty,
        (string?)TempData.Peek("pass2") ?? string.Empty

);
            if (TempData.Peek("name") == null || TempData.Peek("country") == null || TempData.Peek("email") == null)
            {
                return RedirectToAction("Index");
            }
            return View(novUporabnik);
        }
    }
}
