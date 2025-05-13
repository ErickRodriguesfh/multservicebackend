
using Microsoft.EntityFrameworkCore;
using MultService.Domain.Entities;

namespace MultService.Infrastructure.Persistence
{
    public class MultServiceDbContext(DbContextOptions<MultServiceDbContext> options) : DbContext(options)
    {
        public DbSet<Specialty> Specialties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Specialty>().ToTable("Specialty"); // Mapeia para a tabela "Specialty"
        }
    }
}
