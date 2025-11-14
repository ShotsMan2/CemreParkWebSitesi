using Microsoft.EntityFrameworkCore;
using TanıtımWebSitesi.Models.Admin;

namespace TanıtımWebSitesi.Models
{
    public class Context : DbContext
    {
        string baglantı= "Server=.;Database=tanıtım_db;Trusted_Connection=True; Integrated Security=True; TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(baglantı);
        }
        public DbSet<Ablog> Bloglar { get; set; }
        public DbSet<Afirma> firmaBilgileri { get; set; }
        public DbSet<Agaleri> Galeri { get; set; }
        public DbSet<Ailetişim> İletişimFormu { get; set; }
        public DbSet<Akategori> Kategoriler { get; set; }
        public DbSet<Aurun> Ürünler { get; set; }
        public DbSet<Akullanıcılar> Kullanıcılar { get; set; }
    }
}
