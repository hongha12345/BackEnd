using BARBEER_SHOP.DATA;
using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.Models
{
    public class ThoCatTocModel
    {
        [Key]
        public int MaTCT { get; set; }
        [Required]
        [MaxLength(100)]
        public string? TenTCT { get; set; }
        public int? MaCN { get; set; }
    }
}

