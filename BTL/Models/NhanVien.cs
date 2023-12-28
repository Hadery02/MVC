using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models;
    [Table("NhanVien")]
public class NhanVien
{
    [Key]
    public string MaNhanVien { get; set; }
    [Required]
    public string?  TenNV { get; set; }
    [Required]
    public string? DiaChi { get; set; }
    [Required]
    public string? Sdt { get; set; }
    [Required]
    public int Tuoi { get; set; }
}