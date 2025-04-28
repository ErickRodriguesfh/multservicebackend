
using Microsoft.EntityFrameworkCore;
using MultService.Domain.Entities;

namespace MultService.Infrastructure.Persistence
{
    public class MultServiceDbContext(DbContextOptions<MultServiceDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("MultService");

            modelBuilder.Entity<Contractor>()
                .OwnsOne(c => c.Address);

            modelBuilder.Entity<Provider>()
                .HasMany(p => p.Specialties)
                .WithMany(p => p.Providers);
        }
        

        internal DbSet<Provider> Providers { get; set; }
        internal DbSet<Contractor> Contractors { get; set; }
        internal DbSet<Specialty> Specialties { get; set; }
    }
}
