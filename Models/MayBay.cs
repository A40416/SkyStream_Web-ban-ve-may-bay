using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class MayBay
    {
        [Key]
        public long MaMayBay { get; set; }
        public string Site { get; set; }
        public string TenMayBay { get; set; }
        public string HangSanXuat { get; set; }
        public int TongGhe { get; set; }
        public int SoGheLoai1 { get; set; }
        public int SoGheLoai2 { get; set; }
        public string rowguid { get; set; }

    }
}
