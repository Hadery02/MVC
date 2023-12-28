using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models;
    [Table("Phong")]
public class Phong
{
    [Key]
    public int MaPhong { get; set; }
    public string?  TenPhong { get; set; }
    public string? LoaiPhong { get; set; }
    public int? GiaTien { get; set; }
    public int MaKhachHang { get; set; }
    [ForeignKey("MaKhachHang")]
    public KhachHang? KhachHang{get;set;}

}