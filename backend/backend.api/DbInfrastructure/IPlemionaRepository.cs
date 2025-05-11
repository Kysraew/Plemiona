using backend.core.Models;

namespace backend.api.DbInfrastructure {
    public interface IPlemionaRepository {
        IQueryable<Test> Tests { get; }
    }
}