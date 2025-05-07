
using Microsoft.EntityFrameworkCore;
using MultService.Domain.Entities;

namespace MultService.Infrastructure.Persistence
{
    public class MultServiceDbContext(DbContextOptions<MultServiceDbContext> options) : DbContext(options)
    {
        internal DbSet<Provider> Providers { get; set; }
        internal DbSet<Contractor> Contractors { get; set; }
        internal DbSet<Specialty> Specialties { get; set; }
    }
}
