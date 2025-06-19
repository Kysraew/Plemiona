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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Building>().HasData(
                new Building { BuildingId = 1, Name = "Wall", Description = "Provied defence against enemies." }
            );

            modelBuilder.Entity<BuildingUpgrade>().HasData(
                new BuildingUpgrade
                {
                    BuildingUpgradeId = 1,
                    BuildingId = 1,
                    level = 1,
                    DurationSeconds = 100,
                    Gold = 50,
                    Iron = 50,
                    Stone = 100,
                    Wood = 160,
                    PopulationNeeded = 50,
                    GrainPerEmployee = 3
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 1, Name = "Henry", Grain = 100, Gold = 100, Stone = 200, Wood = 400, Iron = 300 },
                new Player { PlayerId = 2, Name = "John", Grain = 100, Gold = 100, Stone = 200, Wood = 400, Iron = 250 }
            );

            modelBuilder.Entity<Town>().HasData(
                new Town { TownId = 1, PlayerId = 1, Name = "Alexandia", Population = 500, X_coordinate = 10, Y_coordinate = 25 }
            );

            modelBuilder.Entity<BuildingInstance>().HasData(
                new BuildingInstance { BuildingInstanceId = 1, BuildingId = 1, TownId = 1, Level = 1 }
            );
        }
    }
}