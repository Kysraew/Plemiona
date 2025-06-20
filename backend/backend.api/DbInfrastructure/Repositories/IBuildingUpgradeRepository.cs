using System.Net.Sockets;
using backend.core.Models;

namespace backend.api.DbInfrastructure.Repositories
{
  public interface IBuildingUpgradeRepository : IRepository<BuildingUpgrade>
  {
    public Task<BuildingUpgrade?> GetByBuildingLevel(long buildingId, int buildingLevel);
  }
}