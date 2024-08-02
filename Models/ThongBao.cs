using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class ThongBao
    {
        [Key]
        public long Ma { get; set; }
        public string NhanVien { get; set; }
        public string ThongBao1 { get; set; }
        public DateTime ThoiGian { get; set; }
        public string rowguid { get; set; }
        public int KiemTraChu { get; set; }
        public int KiemTraTram { get; set; }
    }
}
