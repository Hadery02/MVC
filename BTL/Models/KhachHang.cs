using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models;
    [Table("KhachHang")]
public class KhachHang
{
    [Key]
    public int MaKhachHang { get; set; }
    public string?  HoTen { get; set; }
    public string? DiaChi { get; set; }
    public string? Sdt { get; set; }
    public int Tuoi { get; set; }
    public string? NgayThue { get; set; }
}