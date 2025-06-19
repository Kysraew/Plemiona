
using System.ComponentModel.DataAnnotations;

namespace backend.core.Models
{
    public class Player
    {
        public long PlayerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public int Grain { get; set; }
        public int Gold { get; set; }
        public int Stone { get; set; }
        public int Wood { get; set; }
        public int Iron { get; set; }

        public ICollection<Town> Towns { get; set; } = null!;
    }
}
