using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSR_KAZAR_N1.Controllers
{
    public class UporabnikiController : Controller
    {
        public IActionResult Index()
        {
            DateTime dateTime = new DateTime(2001, 12, 31);
            List<Racun> racuni = new();
            UporabnikModel uporabnik = new("Janez", "Novak", dateTime, "janez.novak@test.com", racuni);
            return View(uporabnik);
        }
    }
}
