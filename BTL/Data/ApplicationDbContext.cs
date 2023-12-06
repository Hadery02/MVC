using Microsoft.EntityFrameworkCore;
using BTL.Models;

namespace BTL.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<KhachHang> KhachHang { get ; set;}
    }
}