using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARBEER_SHOP.DATA
{
    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        [Key]
        public int MaNCC { get; set; }
        [Required]
        [MaxLength(100)]
        public string? TenNCC { get; set; }

        public string? Email { get; set; }

        public string? SDT { get; set; }

        public string? DiaChi { get; set; }

        public virtual ICollection<SanPham>? SanPhams { get; set; }
    }
}
