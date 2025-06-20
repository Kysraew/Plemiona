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
                new Building { BuildingId = 1, Name = "Wall", Description = "Provied defence against enemies." },
                new Building { BuildingId = 2, Name = "Sawmill", Description = "Produce wood." }
            );

            modelBuilder.Entity<BuildingUpgrade>().HasData(
                //Wall
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
                },
                new BuildingUpgrade
                {
                    BuildingUpgradeId = 2,
                    BuildingId = 1,
                    level = 2,
                    DurationSeconds = 200,
                    Gold = 50,
                    Iron = 50,
                    Stone = 150,
                    Wood = 160,
                    PopulationNeeded = 70,
                    GrainPerEmployee = 4
                },

                //sawmill
                new BuildingUpgrade
                {
                    BuildingUpgradeId = 3,
                    BuildingId = 2,
                    level = 1,
                    DurationSeconds = 30,
                    Gold = 5,
                    Iron = 5,
                    Stone = 10,
                    Wood = 16,
                    PopulationNeeded = 50,
                    GrainPerEmployee = 3
                },
                new BuildingUpgrade
                {
                    BuildingUpgradeId = 4,
                    BuildingId = 2,
                    level = 2,
                    DurationSeconds = 50,
                    Gold = 10,
                    Iron = 15,
                    Stone = 10,
                    Wood = 10,
                    PopulationNeeded = 70,
                    GrainPerEmployee = 4
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 1, Name = "Henry", Grain = 1000, Gold = 100, Stone = 200, Wood = 400, Iron = 300 },
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