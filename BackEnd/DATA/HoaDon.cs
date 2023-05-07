using System.ComponentModel.DataAnnotations;

namespace BARBEER_SHOP.DATA
{
    public class HoaDon
    {
        public int MAHD { get; set; }

        public DateTime ThoiGianHD { get; set; }

        public double TongTien { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { set; get; }
        public HoaDon()
        {
            ChiTietHoaDons = new List<ChiTietHoaDon>();
        }
    }
}
