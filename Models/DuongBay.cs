using System.ComponentModel.DataAnnotations;

namespace BanVeMayBay.Models
{
    public class DuongBay
    {
        [Key]
        public long MaDuongBay { get; set; }
        public string Site { get; set; }
        public string ViTri { get; set; }
        public decimal ChieuDai { get; set; }
        public decimal ChieuRong { get; set; }
        public string Status { get; set; }
        public string rowguid { get; set; }

    }
}
