using Microsoft.EntityFrameworkCore;

namespace TPLabo4.Models
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Juego_Genero>().HasKey(jg => new
            {
                jg.juegoId,
                jg.generoId
            });

            modelBuilder.Entity<Juego_Genero>().HasOne(g => g.genero).WithMany(jg => jg.Juegos_Generos).HasForeignKey(g => g.generoId);
            modelBuilder.Entity<Juego_Genero>().HasOne(g => g.juego).WithMany(jg => jg.Juegos_Generos).HasForeignKey(g => g.juegoId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Juego_Genero> Juegos_Generos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }

    }
}
