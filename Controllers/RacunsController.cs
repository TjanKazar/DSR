using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DSR_KAZAR_N1.Controllers
{
    public class RacunsController : Controller
    {
        private readonly dbContext _context;

        // web api here
        //var slika = wait _context.slika.FindAsync()



        public RacunsController(dbContext context)
        {
            _context = context;
        }

        // GET: Racuns
        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("User") || User.IsInRole("Admin"))
            {
                return View(await _context.Racun.ToListAsync());
            }
            return RedirectToAction("Index", "Registracija");
        }

        // GET: Racuns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if(!User.IsInRole("User") && !User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");
            if (id == null)
            {
                return NotFound();
            }

            var racun = await _context.Racun
                .FirstOrDefaultAsync(m => m.Id == id);
            if (racun == null)
            {
                return NotFound();
            }

			return View(racun);
        }

        // GET: Racuns/Create
        public IActionResult Create()
        {
			if (!User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");
			return View();
        }

        // POST: Racuns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,datumIzdaje,cenaSkupaj")] Racun racun)
        {
			if (!User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");

			if (ModelState.IsValid)
            {
				if (!User.IsInRole("User") && !User.IsInRole("Admin"))
					return RedirectToAction("Index", "Registracija");
				_context.Add(racun);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(racun);
        }

        // GET: Racuns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
			if (!User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");
			if (id == null)
            {
                return NotFound();
            }

            var racun = await _context.Racun.FindAsync(id);
            if (racun == null)
            {
                return NotFound();
            }
            return View(racun);
        }

        // POST: Racuns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,datumIzdaje,cenaSkupaj")] Racun racun)
        {
			if (!User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");
			if (id != racun.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(racun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RacunExists(racun.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(racun);
        }

        // GET: Racuns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
			if (!User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");
			if (id == null)
            {
                return NotFound();
            }

            var racun = await _context.Racun
                .FirstOrDefaultAsync(m => m.Id == id);
            if (racun == null)
            {
                return NotFound();
            }

            return View(racun);
        }

        // POST: Racuns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
			if (!User.IsInRole("Admin"))
				return RedirectToAction("Index", "Registracija");
			var racun = await _context.Racun.FindAsync(id);
            if (racun != null)
            {
                _context.Racun.Remove(racun);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RacunExists(int id)
        {
            return _context.Racun.Any(e => e.Id == id);
        }
    }
}
