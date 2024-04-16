using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSR_KAZAR_N1.Models;

namespace DSR_KAZAR_N1.Controllers
{
    public class SlikasController : Controller
    {
        private readonly dbContext _context;

        public SlikasController(dbContext context)
        {
            _context = context;
        }

        // GET: Slikas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slika.ToListAsync());
        }

        // GET: Slikas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slika = await _context.Slika
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slika == null)
            {
                return NotFound();
            }

            return View(slika);
        }

        // GET: Slikas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slikas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ime,cena,letoIzdaje,jeUnikat")] Slika slika)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slika);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slika);
        }

        // GET: Slikas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slika = await _context.Slika.FindAsync(id);
            if (slika == null)
            {
                return NotFound();
            }
            return View(slika);
        }

        // POST: Slikas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ime,cena,letoIzdaje,jeUnikat")] Slika slika)
        {
            if (id != slika.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slika);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlikaExists(slika.Id))
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
            return View(slika);
        }

        // GET: Slikas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slika = await _context.Slika
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slika == null)
            {
                return NotFound();
            }

            return View(slika);
        }

        // POST: Slikas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slika = await _context.Slika.FindAsync(id);
            if (slika != null)
            {
                _context.Slika.Remove(slika);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlikaExists(int id)
        {
            return _context.Slika.Any(e => e.Id == id);
        }
    }
}
