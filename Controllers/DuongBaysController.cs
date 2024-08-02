using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanVeMayBay.Data;
using BanVeMayBay.Models;

namespace BanVeMayBay.Controllers
{
    public class DuongBaysController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public DuongBaysController(BanVeMayBayContext context)
        {
            _context = context;
        }

        // GET: DuongBays
        public async Task<IActionResult> Index()
        {
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return _context.DuongBay != null ?
                        View(await _context.DuongBay.ToListAsync()) :
                        Problem("Entity set 'BanVeMayBayContext.DuongBay'  is null.");
        }

        // GET: DuongBays/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.DuongBay == null)
            {
                return NotFound();
            }

            var duongBay = await _context.DuongBay
                .FirstOrDefaultAsync(m => m.MaDuongBay == id);
            if (duongBay == null)
            {
                return NotFound();
            }

            return View(duongBay);
        }

        // GET: DuongBays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DuongBays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDuongBay,Site,ViTri,ChieuDai,ChieuRong,Status,rowguid")] DuongBay duongBay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duongBay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(duongBay);
        }

        // GET: DuongBays/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.DuongBay == null)
            {
                return NotFound();
            }

            var duongBay = await _context.DuongBay.FindAsync(id);
            if (duongBay == null)
            {
                return NotFound();
            }
            return View(duongBay);
        }

        // POST: DuongBays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("MaDuongBay,Site,ViTri,ChieuDai,ChieuRong,Status,rowguid")] DuongBay duongBay)
        {
            if (id != duongBay.MaDuongBay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duongBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuongBayExists(duongBay.MaDuongBay))
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
            return View(duongBay);
        }

        // GET: DuongBays/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.DuongBay == null)
            {
                return NotFound();
            }

            var duongBay = await _context.DuongBay
                .FirstOrDefaultAsync(m => m.MaDuongBay == id);
            if (duongBay == null)
            {
                return NotFound();
            }

            return View(duongBay);
        }

        // POST: DuongBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.DuongBay == null)
            {
                return Problem("Entity set 'BanVeMayBayContext.DuongBay'  is null.");
            }
            var duongBay = await _context.DuongBay.FindAsync(id);
            if (duongBay != null)
            {
                _context.DuongBay.Remove(duongBay);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuongBayExists(long id)
        {
            return (_context.DuongBay?.Any(e => e.MaDuongBay == id)).GetValueOrDefault();
        }
    }
}
