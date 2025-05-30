using Microsoft.EntityFrameworkCore;
using backend.core.Models;

namespace backend.api.DbInfrastructure
{
    public class PlemionaDbContext : DbContext
    {

        public PlemionaDbContext(DbContextOptions<PlemionaDbContext> options)
            : base(options) { }

        public DbSet<Test> Tests => Set<Test>();
    }
}