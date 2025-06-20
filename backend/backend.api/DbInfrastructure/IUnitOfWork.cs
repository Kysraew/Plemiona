using backend.api.DbInfrastructure.Repositories;
using backend.core.Models;

public interface IUnitOfWork
{
  public IRepository<Player> Players { get; }
  public ITownRepository Towns { get; }
  public IRepository<Building> Buildings { get; }
  public IRepository<BuildingInstance> BuildingInstances { get; }
  public IBuildingUpgradeRepository BuildingUpgrades { get; }

  public Task<int> CompleteAsync();

}