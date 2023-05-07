using AutoMapper;
using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace BARBEER_SHOP.Repositorys
{
    public class DichVuRepository : IDichVuRepository
    {
        private readonly BarberShopContext _context;
        private readonly IMapper _mapper;

        public DichVuRepository(BarberShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddDichVuAsync(DichVuModel model)
        {
            var newdichvu = _mapper.Map<DichVu>(model);
            _context.DichVus!.Add(newdichvu);
            await _context.SaveChangesAsync();
            return newdichvu.MaDV;
        }

        public async Task DeleteDichVuAsync(int madv)
        {
            var deletedichvu = _context.DichVus!.SingleOrDefault(a => a.MaDV == madv);
            if(deletedichvu != null)
            {
                _context.DichVus!.Remove(deletedichvu);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<DichVuModel>> GetAllDichVusAsync()
        {
            var dichvus = await _context.DichVus!.ToListAsync();
            return _mapper.Map<List<DichVuModel>>(dichvus);
        }

        public async Task<DichVuModel> GetDichVuAsync(int madv)
        {
            var dichvu = await _context.DichVus!.FindAsync(madv);
            return _mapper.Map<DichVuModel>(dichvu);
        }

        public async Task UpdateDichVuAsync(int madv, DichVuModel model)
        {
            if (madv == model.MaDV)
            {
                var updatedichvu = _mapper.Map<DichVu>(model);
                _context.DichVus!.Update(updatedichvu);
                await _context.SaveChangesAsync();
            }
        }
    }
}
