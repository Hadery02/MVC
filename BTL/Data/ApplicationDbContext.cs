using Microsoft.EntityFrameworkCore;
using BTL.Models;
using BTL.Migrations;

namespace BTL.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<KhachHang> KhachHang { get ; set;}
        public DbSet<Phong> Phong { get ; set;}
        public DbSet<HoaDon> HoaDon { get ; set;}
        public DbSet<NhanVien> NhanVien {get ; set;}
    }
}