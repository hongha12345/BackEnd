using AutoMapper;
using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Heplpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DichVu, DichVuModel>().ReverseMap();

            CreateMap<LoaiDV, LoaiDVModel>().ReverseMap();

            CreateMap<SanPham, SanPhamModel>().ReverseMap();

            CreateMap<LoaiSP, LoaiSPModel>().ReverseMap();

            CreateMap<NhaCungCap,  NhaCungCapModel>().ReverseMap();

            CreateMap<DonHang, DonHangModel>().ReverseMap();

            CreateMap<HoaDon, HoaDonModel>().ReverseMap();

            CreateMap<LichHen, LichHenModel>().ReverseMap();
        }
    }
}
