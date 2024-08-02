using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class VeBan
    {
        [Key]
        public long MaVe { get; set; }
        public string Site { get; set; }
        public decimal GiaVe { get; set; }
        public decimal TongTienThanhToan { get; set; }
        public string rowguid { get; set; }
        public long MaNhanVien { get; set; }
        public NhanVien? NhanViens { get; set; }
        public long MaKhachHang { get; set; }
        public KhachHang? KhachHangs { get; set; }
        public long MaChuyenBay { get; set; }

    }
}
