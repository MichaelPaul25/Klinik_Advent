using Microsoft.EntityFrameworkCore;
using Website_Klinik.Models;

namespace Website_Klinik.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) :base(options)
        {
            
        }
        public DbSet<TBL_PENDAFTARAN> TBL_PENDAFTARANs { get; set; }
        public DbSet<TBL_PASIEN> TBL_PASIENs { get; set; }
        public DbSet<TBL_ALAMAT> TBL_ALAMATs { get; set; }
    }
}
