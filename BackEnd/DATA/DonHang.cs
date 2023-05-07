using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.DATA
{
    public enum TrangThaiDH
    {
        New = 0, Payment = 1, Complete = 2, Cancel = -1
    }
    public class DonHang
    {
        public int MaDH { get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime? NgayGiao { get; set; }

        public TrangThaiDH TrangThaiDH { get; set; }

        public double TongTien { get; set; }

        public string DiaChiGH { get; set; }

        public ICollection<ChiTietDonHang> ChiTietDonHangs { set; get; }
        
        public DonHang()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
