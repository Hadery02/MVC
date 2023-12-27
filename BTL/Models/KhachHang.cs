using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models;
    [Table("KhachHang")]
public class KhachHang
{
    [Key]
    public int MaKhachHang { get; set; }
    [Required]
    public string?  HoTen { get; set; }
    [Required]
    public string? DiaChi { get; set; }
    [Required]
    public string? Sdt { get; set; }
    [Required]
    public int Tuoi { get; set; }
    [Required]
    public string? NgayThue { get; set; }
}