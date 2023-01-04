using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhuonQuocChien106.Models;

namespace PhuonQuocChien106.Controllers
{
    public class PQC0106Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public PQC0106Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: PQC0106
        public async Task<IActionResult> Index()
        {
              return _context.PQC0106 != null ? 
                          View(await _context.PQC0106.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.PQC0106'  is null.");
        }

        // GET: PQC0106/Details/5
        public async Task<IActionResult> Read(string id)
        {
            if (id == null || _context.PQC0106 == null)
            {
                return NotFound();
            }

            var pQC0106 = await _context.PQC0106
                .FirstOrDefaultAsync(m => m.PQCId == id);
            if (pQC0106 == null)
            {
                return NotFound();
            }

            return View(pQC0106);
        }

        // GET: PQC0106/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PQC0106/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PQCId,PQCName,PQCGender")] PQC0106 pQC0106)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pQC0106);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pQC0106);
        }

        // GET: PQC0106/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.PQC0106 == null)
            {
                return NotFound();
            }

            var pQC0106 = await _context.PQC0106.FindAsync(id);
            if (pQC0106 == null)
            {
                return NotFound();
            }
            return View(pQC0106);
        }

        // POST: PQC0106/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PQCId,PQCName,PQCGender")] PQC0106 pQC0106)
        {
            if (id != pQC0106.PQCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pQC0106);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PQC0106Exists(pQC0106.PQCId))
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
            return View(pQC0106);
        }

        // GET: PQC0106/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.PQC0106 == null)
            {
                return NotFound();
            }

            var pQC0106 = await _context.PQC0106
                .FirstOrDefaultAsync(m => m.PQCId == id);
            if (pQC0106 == null)
            {
                return NotFound();
            }

            return View(pQC0106);
        }

        // POST: PQC0106/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.PQC0106 == null)
            {
                return Problem("Entity set 'MvcMovieContext.PQC0106'  is null.");
            }
            var pQC0106 = await _context.PQC0106.FindAsync(id);
            if (pQC0106 != null)
            {
                _context.PQC0106.Remove(pQC0106);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PQC0106Exists(string id)
        {
          return (_context.PQC0106?.Any(e => e.PQCId == id)).GetValueOrDefault();
        }
    }
}
