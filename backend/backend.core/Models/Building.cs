
using System.ComponentModel.DataAnnotations;

namespace backend.core.Models
{
  public class Building
  {
    public long BuildingId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public ICollection<BuildingUpgrade> BuildingUpgrades { get; set; } = null!;

  }
}
