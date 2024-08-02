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
    public class MayBaysController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public MayBaysController(BanVeMayBayContext context)
        {
            _context = context;
        }

        // GET: MayBays
        public async Task<IActionResult> Index()
        {
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return _context.MayBay != null ?
                        View(await _context.MayBay.ToListAsync()) :
                        Problem("Entity set 'BanVeMayBayContext.MayBay'  is null.");
        }

        // GET: MayBays/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.MayBay == null)
            {
                return NotFound();
            }

            var mayBay = await _context.MayBay
                .FirstOrDefaultAsync(m => m.MaMayBay == id);
            if (mayBay == null)
            {
                return NotFound();
            }

            return View(mayBay);
        }

        // GET: MayBays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MayBays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMayBay,Site,TenMayBay,HangSanXuat,TongGhe,SoGheLoai1,SoGheLoai2,rowguid")] MayBay mayBay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mayBay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mayBay);
        }

        // GET: MayBays/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.MayBay == null)
            {
                return NotFound();
            }

            var mayBay = await _context.MayBay.FindAsync(id);
            if (mayBay == null)
            {
                return NotFound();
            }
            return View(mayBay);
        }

        // POST: MayBays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("MaMayBay,Site,TenMayBay,HangSanXuat,TongGhe,SoGheLoai1,SoGheLoai2,rowguid")] MayBay mayBay)
        {
            if (id != mayBay.MaMayBay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mayBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MayBayExists(mayBay.MaMayBay))
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
            return View(mayBay);
        }

        // GET: MayBays/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.MayBay == null)
            {
                return NotFound();
            }

            var mayBay = await _context.MayBay
                .FirstOrDefaultAsync(m => m.MaMayBay == id);
            if (mayBay == null)
            {
                return NotFound();
            }

            return View(mayBay);
        }

        // POST: MayBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.MayBay == null)
            {
                return Problem("Entity set 'BanVeMayBayContext.MayBay'  is null.");
            }
            var mayBay = await _context.MayBay.FindAsync(id);
            if (mayBay != null)
            {
                _context.MayBay.Remove(mayBay);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MayBayExists(long id)
        {
            return (_context.MayBay?.Any(e => e.MaMayBay == id)).GetValueOrDefault();
        }
    }
}
