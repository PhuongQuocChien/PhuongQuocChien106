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
    public class UniversityPQC106Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public UniversityPQC106Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: UniversityPQC106
        public async Task<IActionResult> Index()
        {
              return _context.UniversityPQC106 != null ? 
                          View(await _context.UniversityPQC106.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.UniversityPQC106'  is null.");
        }

        // GET: UniversityPQC106/Details/5
        public async Task<IActionResult> Read(string id)
        {
            if (id == null || _context.UniversityPQC106 == null)
            {
                return NotFound();
            }

            var universityPQC106 = await _context.UniversityPQC106
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityPQC106 == null)
            {
                return NotFound();
            }

            return View(universityPQC106);
        }

        // GET: UniversityPQC106/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityPQC106/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityPQC106 universityPQC106)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityPQC106);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityPQC106);
        }

        // GET: UniversityPQC106/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.UniversityPQC106 == null)
            {
                return NotFound();
            }

            var universityPQC106 = await _context.UniversityPQC106.FindAsync(id);
            if (universityPQC106 == null)
            {
                return NotFound();
            }
            return View(universityPQC106);
        }

        // POST: UniversityPQC106/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityPQC106 universityPQC106)
        {
            if (id != universityPQC106.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityPQC106);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityPQC106Exists(universityPQC106.UniversityId))
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
            return View(universityPQC106);
        }

        // GET: UniversityPQC106/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.UniversityPQC106 == null)
            {
                return NotFound();
            }

            var universityPQC106 = await _context.UniversityPQC106
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityPQC106 == null)
            {
                return NotFound();
            }

            return View(universityPQC106);
        }

        // POST: UniversityPQC106/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.UniversityPQC106 == null)
            {
                return Problem("Entity set 'MvcMovieContext.UniversityPQC106'  is null.");
            }
            var universityPQC106 = await _context.UniversityPQC106.FindAsync(id);
            if (universityPQC106 != null)
            {
                _context.UniversityPQC106.Remove(universityPQC106);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityPQC106Exists(string id)
        {
          return (_context.UniversityPQC106?.Any(e => e.UniversityId == id)).GetValueOrDefault();
        }
    }
}
