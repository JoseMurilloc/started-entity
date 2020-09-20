using EFCore.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebApi.Data
{
    public class HeroiContext : DbContext
    {
      public DbSet<Heroi> Herois { get; set; }
      public DbSet<Batalha> Batalhas { get; set; }
      public DbSet<Arma> Armas { get; set; }
      public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }
      public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }
      public DbSet<TodoItem> TodoItems { get; set; }

      public HeroiContext(DbContextOptions<HeroiContext> options) : base(options)
      {

      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
          modelBuilder.Entity<HeroiBatalha>(entity => {
              entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
          });
      }

      // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      // {
      //     optionsBuilder.UseNpgsql("postgres://postgres:-mur1lo-@localhost:5432/tests");
      // }



      // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      // {
      //     optionsBuilder.UseNpgsql("postgres://postgres:-mur1lo-@localhost:5432/tests");
      // }

    }
}
