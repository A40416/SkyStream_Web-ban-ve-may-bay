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
    public class ThongBaosController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public ThongBaosController(BanVeMayBayContext context)
        {
            _context = context;
        }

        // GET: Admin/ThongBaos
        public async Task<IActionResult> Index()
        {
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return _context.ThongBao != null ?
                        View(await _context.ThongBao.ToListAsync()) :
                        Problem("Entity set 'BanVeMayBayContext.ThongBao'  is null.");
        }

        // GET: Admin/ThongBaos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.ThongBao == null)
            {
                return NotFound();
            }

            var thongBao = await _context.ThongBao
                .FirstOrDefaultAsync(m => m.Ma == id);
            if (thongBao == null)
            {
                return NotFound();
            }

            return View(thongBao);
        }

        // GET: Admin/ThongBaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ThongBaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ma,NhanVien,ThongBao1,ThoiGian,rowguid,KiemTraChu,KiemTraTram")] ThongBao thongBao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thongBao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thongBao);
        }

        // GET: Admin/ThongBaos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.ThongBao == null)
            {
                return NotFound();
            }

            var thongBao = await _context.ThongBao.FindAsync(id);
            if (thongBao == null)
            {
                return NotFound();
            }
            return View(thongBao);
        }

        // POST: Admin/ThongBaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Ma,NhanVien,ThongBao1,ThoiGian,rowguid,KiemTraChu,KiemTraTram")] ThongBao thongBao)
        {
            if (id != thongBao.Ma)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thongBao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThongBaoExists(thongBao.Ma))
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
            return View(thongBao);
        }

        // GET: Admin/ThongBaos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.ThongBao == null)
            {
                return NotFound();
            }

            var thongBao = await _context.ThongBao
                .FirstOrDefaultAsync(m => m.Ma == id);
            if (thongBao == null)
            {
                return NotFound();
            }

            return View(thongBao);
        }

        // POST: Admin/ThongBaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.ThongBao == null)
            {
                return Problem("Entity set 'BanVeMayBayContext.ThongBao'  is null.");
            }
            var thongBao = await _context.ThongBao.FindAsync(id);
            if (thongBao != null)
            {
                _context.ThongBao.Remove(thongBao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThongBaoExists(long id)
        {
            return (_context.ThongBao?.Any(e => e.Ma == id)).GetValueOrDefault();
        }
    }
}
