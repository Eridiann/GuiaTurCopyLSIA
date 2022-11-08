using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GuiaTuristicaLSIA.API.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Anuncio>().Property(f => f.FechaRegistro).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            builder.Entity<Buzon>().Property(f => f.FechaRegistro).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            builder.Entity<Fotografias>().Property(f => f.FechaRegistro).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            builder.Entity<Lugar>().Property(f => f.FechaRegistro).HasDefaultValueSql("SYSDATETIMEOFFSET()");
        }

        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Buzon> Buzones { get; set; }
        public DbSet<CatTipoLugar> CatTiposLugares { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
    }

    
}
