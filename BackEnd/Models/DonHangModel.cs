﻿using BARBEER_SHOP.DATA;

namespace BARBEER_SHOP.Models
{
    public enum TrangThaiDH
    {
        New = 0, Payment = 1, Complete = 2, Cancel = -1
    }
    public class DonHangModel
    {
        public int MaDH { get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime? NgayGiao { get; set; }

        public TrangThaiDH TrangThaiDH { get; set; }

        public double TongTien { get; set; }

        public string DiaChiGH { get; set; }
    }
}
