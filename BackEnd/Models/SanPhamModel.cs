using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.Models
{
    public class SanPhamModel
    {
        public int MaSP { get; set; }

        public string? TenSP { get; set; }

        public double GiaSP { get; set; }

        public string? Hinh { get; set; }

        public string? MoTa { get; set; }

        public int SoLuongTon { get; set; }

        public int? MaLSP { get; set; }

        public int? MaNCC { get; set; }
    }
}
