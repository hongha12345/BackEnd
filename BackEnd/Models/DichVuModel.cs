using BARBEER_SHOP.DATA;
using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.Models
{
    public class DichVuModel
    {
        public int MaDV { get; set; }
        [Required]
        [MaxLength(50)]
        public string? TenDV { get; set; }

        public double GiaDV { get; set; }

        public string? Hinh { get; set; }

        public string? MoTa { get; set; }

        public int? MaLDV { get; set; }
    }
}
