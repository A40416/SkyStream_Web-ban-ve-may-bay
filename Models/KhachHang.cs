using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class KhachHang
    {
        [Key]
        public long MaKhachHang { get; set; }
        public string Site { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string rowguid { get; set; }
    }
}
