using backend.api.DbInfrastructure;
using backend.api.DbInfrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
  private PlemionaDbContext _dbContext;
  private Repository<Task> _tasks;

  public UnitOfWork(PlemionaDbContext dbContext)
  {
    _dbContext = dbContext;
    _tasks = new Repository<Task>(dbContext);
  }

  public IRepository<Task> Tasks => _tasks;
}