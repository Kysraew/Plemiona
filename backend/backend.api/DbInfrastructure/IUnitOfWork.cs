using backend.api.DbInfrastructure.Repositories;

public interface IUnitOfWork
{
  public IRepository<Task> Tasks { get; }
}