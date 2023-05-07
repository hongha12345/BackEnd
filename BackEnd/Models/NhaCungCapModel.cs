using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.Models
{
    public class NhaCungCapModel
    {
        public int MaNCC { get; set; }

        public string? TenNCC { get; set; }

        public string? Email { get; set; }

        public string? SDT { get; set; }

        public string? DiaChi { get; set; }
    }
}
