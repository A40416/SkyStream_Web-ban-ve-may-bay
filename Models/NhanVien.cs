using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class NhanVien
    {
        [Key]
        public long MaNhanVien { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string Site { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string TenNhanVien { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string SoDienThoai { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string ChucVu { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        [DataType(DataType.Password)]
        [Compare("MatKhau", ErrorMessage = "Mật khẩu chưa khớp")]
        public string NhapLaiMatKhau { get; set; }
        public string rowguid { get; set; }
    }
}
