using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ustaVideos.Models;

namespace ustaVideos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Movie> Movie { get; set; }

        public DbSet<Actor_Movie> Actor_Movies { get; set; }
    }
}
