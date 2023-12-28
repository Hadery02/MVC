using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models;
    [Table("NhanVien")]
public class NhanVien
{
    [Key]
    [Display (Name ="Mã Nhân Viên")]
    public string MaNhanVien { get; set; }
    [Required]
    [Display (Name ="Tên Nhân Viên")]
    public string?  TenNV { get; set; }
    [Required]
    [Display (Name ="Địa Chỉ")]
    public string? DiaChi { get; set; }
    [Required]
    [Display (Name ="Số Điện Thoại")]
    public string? Sdt { get; set; }
    [Required]
    [Display (Name ="Tuổi")]
    public int Tuoi { get; set; }
}