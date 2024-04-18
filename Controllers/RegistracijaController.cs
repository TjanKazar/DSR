using DSR_KAZAR_N1.dbContexts;
using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;

namespace DSR_KAZAR_N1.Controllers
{
    public class RegistracijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistracijaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            TempData.Clear();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(page1Model model1, page2Model model2, page3Model model3)
        {
            UporabnikZGesli User = new UporabnikZGesli(
            model1.name,
            model1.surname,
            model1.birthdate,
            model1.birthplace,
            model1.emso,
            model2.address,
            model2.post,
            model2.postnum,
            model2.country,
            model3.email,
            model3.password,
            model3.password2
            );
            await _context.AddAsync(User);
            await _context.SaveChangesAsync();
            TempData["User"] = JsonSerializer.Serialize(User);
            TempData.Keep();


            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("novUporabnik");
        }

        public IActionResult novUporabnik()
        {
            Console.WriteLine(TempData.Peek("postnum"));
           
            if (TempData.Peek("User") == null)
            {
                return RedirectToAction("Index");
            }
            UporabnikZGesli User = JsonSerializer.Deserialize<UporabnikZGesli>(TempData["User"] as string);

            return View(User);
        }
    }
}
