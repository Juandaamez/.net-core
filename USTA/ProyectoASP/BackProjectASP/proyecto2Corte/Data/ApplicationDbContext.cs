using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proyecto2Corte.Models; // Asegúrate de que este namespace coincida con el de tus modelos

namespace proyecto2Corte.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Peticion> Peticion { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar las relaciones entre Usuario, Peticion y Respuesta
            modelBuilder.Entity<Respuesta>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Respuestas)
                .HasForeignKey(r => r.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Respuesta>()
                .HasOne(r => r.Peticion)
                .WithMany(p => p.Respuestas)
                .HasForeignKey(r => r.IdPeticion)
                .OnDelete(DeleteBehavior.Restrict);

            // Aquí puedes agregar configuraciones adicionales si es necesario
        }
    }
}
