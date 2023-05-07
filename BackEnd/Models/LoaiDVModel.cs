using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.Models
{
    public class LoaiDVModel
    {
        public int MaLDV { get; set; }
        [Required]
        [MaxLength(50)]
        public string? TenLDV { get; set; }
    }
}
