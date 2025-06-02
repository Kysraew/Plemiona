using Microsoft.EntityFrameworkCore;
using backend.core.Models;

namespace backend.api.DbInfrastructure
{
    public class PlemionaDbContext : DbContext
    {

        public PlemionaDbContext(DbContextOptions<PlemionaDbContext> options)
            : base(options) { }

        public DbSet<Town> Towns => Set<Town>();
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<BuildingInstance> BuildingInstances => Set<BuildingInstance>();
        public DbSet<BuildingUpgrade> BuildingUpgrades => Set<BuildingUpgrade>();
    }
}