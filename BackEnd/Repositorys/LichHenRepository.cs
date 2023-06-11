using AutoMapper;
using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace BARBEER_SHOP.Repositorys
{
    public class LichHenRepository : ILichHenRepository
    {
        private readonly BarberShopContext _context;
        private readonly IMapper _mapper;

        public LichHenRepository(BarberShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddLichHenAsync(LichHenModel model)
        {
            var newlichhen = _mapper.Map<LichHen>(model);
            _context.LichHens!.Add(newlichhen);
            await _context.SaveChangesAsync();
            return newlichhen.MaLH;
        }

        public async Task DeleteLichHenAsync(int malh)
        {
            var deletelichhen = _context.LichHens!.SingleOrDefault(a => a.MaLH == malh);
            if (deletelichhen != null)
            {
                _context.LichHens!.Remove(deletelichhen);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<LichHenModel>> GetAllLichHensAsync()
        {
            var lichhens = await _context.LichHens!.ToListAsync();
            return _mapper.Map<List<LichHenModel>>(lichhens);
        }

        public async Task<LichHenModel> GetLichHenAsync(int malh)
        {
            var lichhen = await _context.LichHens!.FindAsync(malh);
            return _mapper.Map<LichHenModel>(lichhen);
        }

        public async Task UpdateLichHenAsync(int malh, LichHenModel model)
        {
            if (malh == model.MaLH)
            {
                var updatelichhen = _mapper.Map<LichHen>(model);
                _context.LichHens!.Update(updatelichhen);
                await _context.SaveChangesAsync();
            }
        }
    }
}
