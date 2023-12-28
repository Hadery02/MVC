using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        public int MaKhachHang { get; set; }
           [ForeignKey("MaKhachHang")]
        public KhachHang? KhachHang{get;set;}
        public int ThanhTien { get; set; }
        
        public string? NgayThanhToan { get; set; }
        public string MaNhanVien { get; set; }
         [ForeignKey("MaNhanVien")]
        public NhanVien? NhanVien{get;set;}
     
    
    }
}