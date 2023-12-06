using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        public int MaPhong { get; set; }
        public int ThanhTien { get; set; }
        public string? NgayThanhToan { get; set; }
        [ForeignKey("MaKhachHang")]
        public KhachHang? KhachHang{get;set;}

        [ForeignKey("MaPhong")]
        public Phong? Phong{get;set;}     
    }
}