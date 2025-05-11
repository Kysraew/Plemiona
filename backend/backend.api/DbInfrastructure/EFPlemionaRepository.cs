using backend.core.Models;

namespace backend.api.DbInfrastructure  {
    public class EFPlemionaRepository : IPlemionaRepository {
        private StoreDbContext context;
                
        public EFPlemionaRepository(StoreDbContext ctx) {
            context = ctx;
        }
                
        public IQueryable<Test> Tests => context.Tests;

    }
}