using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARBEER_SHOP.DATA
{
    [Table("LichHen")]
    public class LichHen
    {
        [Key]
        public int MALH { get; set; }

        public DateTime ThoiGianBD { get; set; }

        public DateTime ThoiGianKT { get; set; }

        public DateTime NgayHen { get; set; }

        public int? MaDV { get; set; }
        [ForeignKey("MaDV")]
        public DichVu? DichVu { get; set; }
    }
}
