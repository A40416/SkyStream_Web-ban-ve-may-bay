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
    public class VeBansController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public VeBansController(BanVeMayBayContext context)
        {
            _context = context;
        }

        // GET: VeBans
        public async Task<IActionResult> Index()
        {
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return _context.VeBan != null ?
                        View(await _context.VeBan.ToListAsync()) :
                        Problem("Entity set 'BanVeMayBayContext.VeBan'  is null.");
        }

        // GET: VeBans/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.VeBan == null)
            {
                return NotFound();
            }

            var veBan = await _context.VeBan
                .FirstOrDefaultAsync(m => m.MaVe == id);
            if (veBan == null)
            {
                return NotFound();
            }

            return View(veBan);
        }

        // GET: VeBans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VeBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaVe,Site,GiaVe,TongTienThanhToan,rowguid, MaNhanVien, MaKhachHang, MaChuyenBay")] VeBan veBan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veBan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veBan);
        }

        // GET: VeBans/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.VeBan == null)
            {
                return NotFound();
            }

            var veBan = await _context.VeBan.FindAsync(id);
            if (veBan == null)
            {
                return NotFound();
            }
            return View(veBan);
        }

        // POST: VeBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("MaVe,Site,GiaVe,TongTienThanhToan,rowguid, MaNhanVien, MaKhachHang, MaChuyenBay")] VeBan veBan)
        {
            if (id != veBan.MaVe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veBan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeBanExists(veBan.MaVe))
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
            return View(veBan);
        }

        // GET: VeBans/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.VeBan == null)
            {
                return NotFound();
            }

            var veBan = await _context.VeBan
                .FirstOrDefaultAsync(m => m.MaVe == id);
            if (veBan == null)
            {
                return NotFound();
            }

            return View(veBan);
        }

        // POST: VeBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.VeBan == null)
            {
                return Problem("Entity set 'BanVeMayBayContext.VeBan'  is null.");
            }
            var veBan = await _context.VeBan.FindAsync(id);
            if (veBan != null)
            {
                _context.VeBan.Remove(veBan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeBanExists(long id)
        {
            return (_context.VeBan?.Any(e => e.MaVe == id)).GetValueOrDefault();
        }
    }
}
