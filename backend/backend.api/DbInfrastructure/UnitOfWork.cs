using backend.api.DbInfrastructure;
using backend.api.DbInfrastructure.Repositories;
using backend.core.Models;

public class UnitOfWork : IUnitOfWork
{
  private PlemionaDbContext _dbContext;
  private Repository<Player> _players;
  private TownRepository _towns;
  private Repository<Building> _buildings;
  private Repository<BuildingInstance> _buildingInstances;
  private BuildingUpgradeRepository _buildingUpgrades;


  public UnitOfWork(PlemionaDbContext dbContext)
  {
    _dbContext = dbContext;
    _players = new Repository<Player>(dbContext);
    _towns = new TownRepository(dbContext);
    _buildings = new Repository<Building>(dbContext);
    _buildingInstances = new Repository<BuildingInstance>(dbContext);
    _buildingUpgrades = new BuildingUpgradeRepository(dbContext);
  }

  public IRepository<Player> Players => _players;
  public ITownRepository Towns => _towns;

  public IRepository<Building> Buildings => _buildings;
  public IRepository<BuildingInstance> BuildingInstances => _buildingInstances;
  public IBuildingUpgradeRepository BuildingUpgrades => _buildingUpgrades;

  public async Task<int> CompleteAsync()
  {
    return await _dbContext.SaveChangesAsync();
  }

}
