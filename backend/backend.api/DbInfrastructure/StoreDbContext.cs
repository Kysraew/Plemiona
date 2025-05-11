using Microsoft.EntityFrameworkCore;
using backend.core.Models;

namespace backend.api.DbInfrastructure {
    public class StoreDbContext : DbContext {
        
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }
                        
        public DbSet<Test> Tests => Set<Test>();
    }
}