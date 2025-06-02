
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace backend.core.Models
{
  public class BuildingInstance
  {
    public long BuildingInstanceId { get; set; }

    [Required]
    [MaxLength(50)]
    public int Level { get; set; }
    public long BuildingId { get; set; }
    public Building Building { get; set; } = null!;

    public long TownId { get; set; }
    public Town Town { get; set; } = null!;

  }
}
