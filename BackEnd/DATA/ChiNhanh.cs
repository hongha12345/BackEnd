using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARBEER_SHOP.DATA
{
    [Table("ChiNhanh")]
    public class ChiNhanh
    {
        [Key]
        public int MaCN { get; set; }

        [Required]
        [MaxLength(100)]
        public string? TenCN { get; set; }

        public virtual ICollection<LichHen>? LichHens { get; set; }
    }
}
