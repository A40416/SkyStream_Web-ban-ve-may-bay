using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class ChuyenBay
    {

        [Key]
        public long MaChuyenBay { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string Site { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public DateTime GioBay { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string DiemDi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public string DiemDen { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public DateTime NgayDi { get; set; }
        public string? GhiChu { get; set; }
        public string? rowguid { get; set; }
        /*[Required(ErrorMessage = "Vui lòng nhập đầy đủ")]
        public long MaDuongBay { get; set; }
        public DuongBay? DuongBays { get; set; }
        public long MaMayBay { get; set; }
        public MayBay? MayBays { get; set; }
        public string TenMayBay { get; set; }
        public string TenDuongBay { get; set; }*/

    }
}
