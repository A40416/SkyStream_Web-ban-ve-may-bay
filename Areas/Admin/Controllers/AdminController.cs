using BanVeMayBay.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BanVeMayBay.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public AdminController(BanVeMayBayContext context)
        {
            _context = context;
        }
        // GET: AdminController
        public ActionResult Index()
        {
            ViewBag.Message2 = HttpContext.Session.GetString("username");
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        

        public ActionResult DangKy()
        {
            return View();
        }


    }
}
