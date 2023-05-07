using AutoMapper;
using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace BARBEER_SHOP.Repositorys
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly BarberShopContext _context;
        private readonly IMapper _mapper;

        public SanPhamRepository(BarberShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddSanPhamAsync(SanPhamModel model)
        {
            var newsanpham = _mapper.Map<SanPham>(model);
            _context.SanPhams!.Add(newsanpham);
            await _context.SaveChangesAsync();
            return newsanpham.MaSP;
        }

        public async Task DeleteSanPhamAsync(int masp)
        {
            var deletesanpham = _context.SanPhams!.SingleOrDefault(a => a.MaSP == masp);
            if (deletesanpham != null)
            {
                _context.SanPhams!.Remove(deletesanpham);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<SanPhamModel>> GetAllSanPhamsAsync()
        {
            var sanphams = await _context.SanPhams!.ToListAsync();
            return _mapper.Map<List<SanPhamModel>>(sanphams);
        }

        public async Task<SanPhamModel> GetSanPhamAsync(int masp)
        {
            var sanpham = await _context.SanPhams!.FindAsync(masp);
            return _mapper.Map<SanPhamModel>(sanpham);
        }

        public async Task UpdateSanPhamAsync(int masp, SanPhamModel model)
        {
            if (masp == model.MaSP)
            {
                var updatesanpham = _mapper.Map<SanPham>(model);
                _context.SanPhams!.Update(updatesanpham);
                await _context.SaveChangesAsync();
            }
        }
    }
}
