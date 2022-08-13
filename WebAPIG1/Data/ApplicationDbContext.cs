using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPIG1.Models;

namespace WebAPIG1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animales { get; set; }

        public DbSet<Raza> Razas { get; set; }

        public DbSet<TipoAnimal> TipoAnimales { get; set; }
    }
}