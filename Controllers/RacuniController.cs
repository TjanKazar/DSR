using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSR_KAZAR_N1.Controllers
{
    public class RacuniController : Controller
    {
        public IActionResult Index()
        {
            DateTime datumIzdaje = new DateTime(2024, 3, 14);
            List<SlikaModel> nakupList = new List<SlikaModel>();
            decimal cenaSkupaj = 100.50m;

            Racun racun = new Racun(datumIzdaje, nakupList, cenaSkupaj);
            ViewBag.Racun = racun;
            return View();
        }
    }
}
