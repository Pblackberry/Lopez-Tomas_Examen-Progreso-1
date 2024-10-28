using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lopez_Tomas_Examen_Progreso_1.Models;

namespace Lopez_Tomas_Examen_Progreso_1.Controllers
{
    public class LopezController : Controller
    {
        private readonly LopezTomas_Context _context;

        public LopezController(LopezTomas_Context context)
        {
            _context = context;
        }

        // GET: Lopez
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lopez.ToListAsync());
        }

        // GET: Lopez/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lopez = await _context.Lopez
                .FirstOrDefaultAsync(m => m.IDlopez == id);
            if (lopez == null)
            {
                return NotFound();
            }

            return View(lopez);
        }

        // GET: Lopez/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lopez/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDlopez,nombre,Ncelular,afiliado,fecha,decFav")] Lopez lopez)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lopez);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lopez);
        }

        // GET: Lopez/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lopez = await _context.Lopez.FindAsync(id);
            if (lopez == null)
            {
                return NotFound();
            }
            return View(lopez);
        }

        // POST: Lopez/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDlopez,nombre,Ncelular,afiliado,fecha,decFav")] Lopez lopez)
        {
            if (id != lopez.IDlopez)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lopez);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LopezExists(lopez.IDlopez))
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
            return View(lopez);
        }

        // GET: Lopez/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lopez = await _context.Lopez
                .FirstOrDefaultAsync(m => m.IDlopez == id);
            if (lopez == null)
            {
                return NotFound();
            }

            return View(lopez);
        }

        // POST: Lopez/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lopez = await _context.Lopez.FindAsync(id);
            if (lopez != null)
            {
                _context.Lopez.Remove(lopez);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LopezExists(int id)
        {
            return _context.Lopez.Any(e => e.IDlopez == id);
        }
    }
}
