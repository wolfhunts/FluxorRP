using Microsoft.EntityFrameworkCore;

namespace FluxorRP.Shared.Data
{
    public class FluxorRPContext : DbContext
    {
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Character> Characters { get; set; }

        public string DbPath { get; }

       
        public FluxorRPContext(DbContextOptions<FluxorRPContext> options)
        : base(options)
        {
            DbPath = System.IO.Path.Join(Directory.GetCurrentDirectory(), "FluxorRP.db");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasKey(c => c.Id); // Définition explicite de la clé primaire
            modelBuilder.Entity<Monster>()
                .HasKey(c => c.Id); // Définition explicite de la clé primaire
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
