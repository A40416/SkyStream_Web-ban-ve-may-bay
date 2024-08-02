using BanVeMayBay.Data;
using BanVeMayBay.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BanVeMayBay.Controllers
{
    public class LoginController : Controller
    {
        private readonly BanVeMayBayContext _context;

        public LoginController(BanVeMayBayContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> DangNhapAsync(Login Lo)
        {
            var query = _context.NhanVien.SingleOrDefault(m => m.TenDangNhap == Lo.UserName && m.MatKhau == Lo.Password);
            if (query != null)
            {
                var claims = new List<Claim>()
                {
                    new Claim("username",Lo.UserName)
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                HttpContext.Session.SetString("username", Lo.UserName);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                Response.WriteAsync("<script>alert('Login Error')</script>");
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            //HttpContext.Session.Remove("email");
            return RedirectToAction("Index", "Home");
        }
    }
}
