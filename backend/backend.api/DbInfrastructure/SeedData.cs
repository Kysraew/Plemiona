using Microsoft.EntityFrameworkCore;
using backend.core.Models;

namespace backend.api.DbInfrastructure
{
  public static class SeedData
  {

    public static void SeedDatabase(IApplicationBuilder app)
    {
      PlemionaDbContext context = app.ApplicationServices
               .CreateScope().ServiceProvider
               .GetRequiredService<PlemionaDbContext>();
      if (context.Tests.Count() == 0)
      {
        context.Tests.AddRange(new Test { x = 10 },
        new Test { x = 11 },
        new Test { x = 12 },
        new Test { x = 13 });
      }
    }

  }
}
