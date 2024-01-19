using APIWebsite_Klinik.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWebsite_Klinik.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {
            
        }
        public DbSet<TBL_PENDAFTARAN> TBL_PENDAFTARANs { get; set; }
        public DbSet<TBL_PASIEN> TBL_PASIENs { get; set; }
        public DbSet<TBL_ALAMAT> TBL_ALAMATs { get; set; }
    }
}
