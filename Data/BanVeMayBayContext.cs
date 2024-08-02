using Microsoft.EntityFrameworkCore;
using BanVeMayBay.Models;

namespace BanVeMayBay.Data
{
    public class BanVeMayBayContext : DbContext
    {
        public BanVeMayBayContext (DbContextOptions<BanVeMayBayContext> options)
            : base(options)
        {
        }

        public DbSet<ThongBao> ThongBao { get; set; } = default!;

        public DbSet<DuongBay>? DuongBay { get; set; }

        public DbSet<MayBay>? MayBay { get; set; }

        public DbSet<ChuyenBay>? ChuyenBay { get; set; }

        public DbSet<NhanVien>? NhanVien { get; set; }

        public DbSet<KhachHang>? KhachHang { get; set; }

        public DbSet<VeBan>? VeBan { get; set; }
    }
}
