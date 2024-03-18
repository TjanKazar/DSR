using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSR_KAZAR_N1.Controllers
{
    public class SlikeController : Controller
    {
        public IActionResult Index()
        {
            SlikaModel slika = new("Drawing", 99.99m, 2001, true);
            return View(slika);
        }
    }
}
