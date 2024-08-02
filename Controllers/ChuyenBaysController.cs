using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BanVeMayBay.Data;
using BanVeMayBay.Models;

namespace BanVeMayBay.Controllers
{
    public class ChuyenBaysController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public ChuyenBaysController(BanVeMayBayContext context)
        {
            _context = context;
        }

        // GET: ChuyenBays
        public async Task<IActionResult> Index(string name,string diemdi)
        {
            var search = from b in _context.ChuyenBay select b;
            if (!string.IsNullOrEmpty(name))
            {
                search = search.Where(a => a.DiemDen.Contains(name));

            }
            if (!string.IsNullOrEmpty(diemdi))
            {
                search = search.Where(a => a.DiemDi.Contains(diemdi));

            }
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return View(search);
                //_context.ChuyenBay != null ?
                //        View(await _context.ChuyenBay.ToListAsync()) :
                //        Problem("Entity set 'BanVeMayBayContext.ChuyenBay'  is null.");
        }

        // GET: ChuyenBays/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.ChuyenBay == null)
            {
                return NotFound();
            }

            var chuyenBay = await _context.ChuyenBay.FirstOrDefaultAsync(m => m.MaChuyenBay == id);
            if (chuyenBay == null)
            {
                return NotFound();
            }

            /*var mayBay = await _context.MayBay.FirstOrDefaultAsync(x => x.MaMayBay == chuyenBay.MaMayBay);
            chuyenBay.TenMayBay = mayBay?.TenMayBay;
            var duongBay = await _context.DuongBay.FirstOrDefaultAsync(x => x.MaDuongBay == chuyenBay.MaDuongBay);
            chuyenBay.TenDuongBay = duongBay?.ViTri;*/

            return View(chuyenBay);
        }

        // GET: ChuyenBays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChuyenBays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChuyenBay,Site,GioBay,DiemDi,DiemDen,NgayDi,GhiChu,rowguid, MaDuongBay, MaMayBay")] ChuyenBay chuyenBay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuyenBay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuyenBay);
        }

        // GET: ChuyenBays/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.ChuyenBay == null)
            {
                return NotFound();
            }

            var chuyenBay = await _context.ChuyenBay.FindAsync(id);
            if (chuyenBay == null)
            {
                return NotFound();
            }
            return View(chuyenBay);
        }

        // POST: ChuyenBays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("MaChuyenBay,Site,GioBay,DiemDi,DiemDen,NgayDi,GhiChu,rowguid, MaDuongBay, MaMayBay")] ChuyenBay chuyenBay)
        {
            if (id != chuyenBay.MaChuyenBay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuyenBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyenBayExists(chuyenBay.MaChuyenBay))
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
            return View(chuyenBay);
        }

        // GET: ChuyenBays/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.ChuyenBay == null)
            {
                return NotFound();
            }

            var chuyenBay = await _context.ChuyenBay
                .FirstOrDefaultAsync(m => m.MaChuyenBay == id);
            if (chuyenBay == null)
            {
                return NotFound();
            }

            return View(chuyenBay);
        }

        // POST: ChuyenBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.ChuyenBay == null)
            {
                return Problem("Entity set 'BanVeMayBayContext.ChuyenBay'  is null.");
            }
            var chuyenBay = await _context.ChuyenBay.FindAsync(id);
            if (chuyenBay != null)
            {
                _context.ChuyenBay.Remove(chuyenBay);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuyenBayExists(long id)
        {
            return (_context.ChuyenBay?.Any(e => e.MaChuyenBay == id)).GetValueOrDefault();
        }
    }
}
