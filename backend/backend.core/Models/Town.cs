
using System.ComponentModel.DataAnnotations;

namespace backend.core.Models
{
  public class Town
  {
    public long TownId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    public int Population { get; set; }
    public int X_coordinate { get; set; }
    public int Y_coordinate { get; set; }

    public ICollection<BuildingInstance> BuildingInstances { get; set; } = null!;
    public long PlayerId { get; set; }
    public Player Player { get; set; } = null!;

  }
}
