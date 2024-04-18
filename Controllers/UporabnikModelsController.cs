using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DSR_KAZAR_N1.Controllers
{
    public class UporabnikModelsController : Controller
    {
        private readonly dbContext _context;

        public UporabnikModelsController(dbContext context)
        {
            _context = context;
        }

        // GET: UporabnikModels
        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("User") || User.IsInRole("Admin"))
            {
                return View(await _context.Uporabnik.ToListAsync());
            }
            return RedirectToAction("Index", "Registracija");
        }

        // GET: UporabnikModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uporabnikModel = await _context.Uporabnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uporabnikModel == null)
            {
                return NotFound();
            }

            return View(uporabnikModel);
        }

        // GET: UporabnikModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UporabnikModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,surname,birthdate,birthplace,emso,address,post,postnum,country,email")] UporabnikModel uporabnikModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uporabnikModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uporabnikModel);
        }

        // GET: UporabnikModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uporabnikModel = await _context.Uporabnik.FindAsync(id);
            if (uporabnikModel == null)
            {
                return NotFound();
            }
            return View(uporabnikModel);
        }

        // POST: UporabnikModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,surname,birthdate,birthplace,emso,address,post,postnum,country,email")] UporabnikModel uporabnikModel)
        {
            if (id != uporabnikModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uporabnikModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UporabnikModelExists(uporabnikModel.Id))
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
            return View(uporabnikModel);
        }

        // GET: UporabnikModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uporabnikModel = await _context.Uporabnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uporabnikModel == null)
            {
                return NotFound();
            }

            return View(uporabnikModel);
        }

        // POST: UporabnikModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uporabnikModel = await _context.Uporabnik.FindAsync(id);
            if (uporabnikModel != null)
            {
                _context.Uporabnik.Remove(uporabnikModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UporabnikModelExists(int id)
        {
            return _context.Uporabnik.Any(e => e.Id == id);
        }
    }
}
