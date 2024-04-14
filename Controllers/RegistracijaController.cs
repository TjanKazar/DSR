using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult Index(page1Model model1, page2Model model2, page3Model model3)
        {
            TempData["name"] = model1.name;
            TempData["surname"] = model1.surname;
            TempData["birthdate"] = model1.birthdate;
            TempData["birthplace"] = model1.birthplace;
            TempData["emso"] = model1.emso;
            TempData["address"] = model2.address;
            TempData["postnum"] = model2.postnum;
            TempData["post"] = model2.post;
            TempData["country"] = model2.country;
            TempData["email"] = model3.email;
            TempData["pass1"] = model3.password;
            TempData["pass2"] = model3.password2;
            TempData.Keep();
            ModelState.Remove("receipts");
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("novUporabnik");
        }

        public IActionResult novUporabnik()
        {
            Console.WriteLine(TempData.Peek("postnum"));
            UporabnikModel Uporabnik = new((string?)TempData.Peek("name") ?? string.Empty,
    (string?)TempData.Peek("surname") ?? string.Empty,
    (DateTime?)TempData.Peek("birthdate") ?? DateTime.MinValue,
    (string?)TempData.Peek("birthplace") ?? string.Empty,
    (string?)TempData.Peek("emso") ?? string.Empty,
    (string?)TempData.Peek("address") ?? string.Empty,
    (string?)TempData.Peek("post") ?? string.Empty,
    (int?)TempData.Peek("postnum") ?? 0,
    (string?)TempData.Peek("country") ?? string.Empty,
    (string?)TempData.Peek("email") ?? string.Empty);
           
            if (TempData.Peek("name") == null || TempData.Peek("country") == null || TempData.Peek("email") == null)
            {
                return RedirectToAction("Index");
            }
            return View(Uporabnik);
        }
    }
}
