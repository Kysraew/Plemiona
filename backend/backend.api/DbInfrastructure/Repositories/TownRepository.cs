using backend.core.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace backend.api.DbInfrastructure.Repositories
{
  public class TownRepository : Repository<Town>, ITownRepository
  {

    public TownRepository(PlemionaDbContext dbContext) :
    base(dbContext)
    {
    }
    override public async Task<Town?> GetById(long Id)
    {
      return await _dbSet
      .Where(t => t.TownId == Id)
      .Include(t => t.Player)
      .Include(t => t.BuildingInstances)
      .ThenInclude(b => b.Building)
      .FirstOrDefaultAsync();
    }
  }
}