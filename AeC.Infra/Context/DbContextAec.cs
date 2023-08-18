using AeC.Domain.Models;
using AeC.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace AeC.Infra.Context
{
    public class DbContextAec : DbContext
    {
        public DbSet<AeroportoClima>? AeroportosClima { get; set; }
        public DbSet<CidadeClima>? CidadesClima { get; set; }
        public DbSet<CidadeClima>? CidadesClimaDias { get; set; }
        public DbSet<Log>? Log { get; set; }


        public DbContextAec(DbContextOptions<DbContextAec> options)
             : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CidadeClima>()
            .HasMany(x => x.Clima)
            .WithOne(x => x.CidadeClima)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<CidadeClima>()
                .OwnsOne(c => c.Endereco,
                endereco =>
                {
                    endereco.Property(e => e.Cidade).HasColumnName("Cidade");
                    endereco.Property(e => e.Estado).HasColumnName("Estado");
                });
        }
    }
}


