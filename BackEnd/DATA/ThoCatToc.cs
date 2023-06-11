using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARBEER_SHOP.DATA
{
    [Table("ThoCatToc")]
    public class ThoCatToc
    {
        [Key]
        public int MaTCT { get; set; }
        [Required]
        [MaxLength(100)]
        public string? TenTCT { get; set; }

        public int? MaCN { get; set; }

        public virtual ICollection<LichHen>? LichHens { get; set; }
    }
}
