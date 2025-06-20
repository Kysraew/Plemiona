using backend.core.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace backend.api.DbInfrastructure.Repositories
{
  public class BuildingUpgradeRepository : Repository<BuildingUpgrade>, IBuildingUpgradeRepository
  {

    public BuildingUpgradeRepository(PlemionaDbContext dbContext) :
    base(dbContext)
    {
    }

    public async Task<BuildingUpgrade?> GetByBuildingLevel(long buildingId, int buildingLevel)
    {
      return await _dbSet
      .Where(bu => bu.BuildingId == buildingId && bu.level == buildingLevel)
      .FirstOrDefaultAsync();
    }
  }
}