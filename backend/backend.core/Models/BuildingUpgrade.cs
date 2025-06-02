
using System.ComponentModel.DataAnnotations;

namespace backend.core.Models
{
  public class BuildingUpgrade
  {
    public long BuildingUpgradeId { get; set; }
    public long BuildingId { get; set; }
    public long DurationSeconds { get; set; }

    public int level { get; set; }
    public int Gold { get; set; }
    public int Wood { get; set; }
    public int Stone { get; set; }
    public int Iron { get; set; }
    public int PopulationNeeded { get; set; }
  }
}
