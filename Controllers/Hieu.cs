using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KiemTraMvc.Data;
using KiemTraMvc.Models;

namespace KiemTraMvc.Controllers
{
    public class Hieu : Controller
    {
        private readonly ApplicationDbContext _context;

        public Hieu(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hieu
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Hieu/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hieu = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hieu == null)
            {
                return NotFound();
            }

            return View(hieu);
        }

        // GET: Hieu/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hieu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName")] Hieu hieu)
        {
            if (ModelState.IsValid)
            {
                hieu.Id = Guid.NewGuid();
                _context.Add(hieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hieu);
        }

        // GET: Hieu/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hieu = await _context.Users.FindAsync(id);
            if (hieu == null)
            {
                return NotFound();
            }
            return View(hieu);
        }

        // POST: Hieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FullName")] Hieu hieu)
        {
            if (id != hieu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HieuExists(hieu.Id))
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
            return View(hieu);
        }

        // GET: Hieu/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hieu = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hieu == null)
            {
                return NotFound();
            }

            return View(hieu);
        }

        // POST: Hieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var hieu = await _context.Users.FindAsync(id);
            if (hieu != null)
            {
                _context.Users.Remove(hieu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HieuExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
