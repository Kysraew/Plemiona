using backend.core.Models;
using Microsoft.AspNetCore.SignalR;

namespace backend.api.DbInfrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        public IAsyncEnumerable<T> GetAllAsync();
        public Task<T?> GetById(long Id);

    }
}