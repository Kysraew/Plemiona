using backend.core.Models;
using Microsoft.AspNetCore.SignalR;

namespace backend.api.DbInfrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();

    }
}