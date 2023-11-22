using Domain.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain;
public class AppDbContext : DbContext
{
    public DbSet<Plate> Plates => Set<Plate>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
