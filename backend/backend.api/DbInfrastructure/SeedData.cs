using Microsoft.EntityFrameworkCore;
using backend.core.Models;

namespace backend.api.DbInfrastructure
{
  public static class SeedData
  {

    public static void SeedDatabase(IApplicationBuilder app)
    {
      PlemionaDbContext context = app.ApplicationServices
               .CreateScope().ServiceProvider
               .GetRequiredService<PlemionaDbContext>();


      if (context.Buildings.Count() == 0)
      {
        context.Buildings.AddRange(new Building { Name = "Hall", Description = "Main palace where town council resides." });
      }
      context.SaveChanges();

      if (context.BuildingUpgrades.Count() == 0)
      {
        context.BuildingUpgrades.AddRange(new BuildingUpgrade { DurationSeconds = 100, level = 1, BuildingId = 1, Gold = 50, Iron = 50, Stone = 100, Wood = 160, PopulationNeeded = 50 });

      }

      context.SaveChanges();

      if (context.Players.Count() == 0)
      {
        context.Players.AddRange(
          new Player { Name = "Henry", Gold = 100, Stone = 200, Wood = 400, Iron = 300 },
          new Player { Name = "John", Gold = 100, Stone = 200, Wood = 400, Iron = 250 });
      }
      context.SaveChanges();

      if (context.Towns.Count() == 0)
      {
        context.Towns.AddRange(new Town { Name = "Alexandia", PlayerId = 1, Population = 500, X_coordinate = 10, Y_coordinate = 25 });
      }
      context.SaveChanges();

      if (context.BuildingInstances.Count() == 0)
      {
        context.BuildingInstances.AddRange(new BuildingInstance { BuildingId = 1, Level = 1, TownId = 1 });
      }

      context.SaveChanges();
    }

  }
}
