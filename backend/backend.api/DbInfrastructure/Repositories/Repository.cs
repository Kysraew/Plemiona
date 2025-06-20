using backend.core.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace backend.api.DbInfrastructure.Repositories
{
  public class Repository<T> : IRepository<T> where T : class
  {
    protected PlemionaDbContext _dbContext;
    protected readonly DbSet<T> _dbSet;

    public Repository(PlemionaDbContext dbContext)
    {
      _dbContext = dbContext;
      _dbSet = dbContext.Set<T>();
    }

    public virtual IAsyncEnumerable<T> GetAllAsync()
    {
      return _dbSet.AsAsyncEnumerable();
    }

    public virtual async Task<T?> GetById(long Id)
    {
      return await _dbSet.FindAsync(Id);
    }

    public async Task Update(T t)
    {
      _dbSet.Update(t);
      await _dbContext.SaveChangesAsync();
    }
  }
}