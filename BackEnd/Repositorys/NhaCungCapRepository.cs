using AutoMapper;
using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace BARBEER_SHOP.Repositorys
{
    public class NhaCungCapRepository : INhaCungCapRepository
    {
        private readonly BarberShopContext _context;
        private readonly IMapper _mapper;

        public NhaCungCapRepository(BarberShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddNCCAsync(NhaCungCapModel model)
        {
            var newncc = _mapper.Map<NhaCungCap>(model);
            _context.NhaCungCaps!.Add(newncc);
            await _context.SaveChangesAsync();
            return newncc.MaNCC;
        }

        public async Task DeleteNCCAsync(int mancc)
        {
            var deletencc = _context.NhaCungCaps!.SingleOrDefault(a => a.MaNCC == mancc);
            if (deletencc != null)
            {
                _context.NhaCungCaps!.Remove(deletencc);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<NhaCungCapModel>> GetAllNCCsAsync()
        {
            var nccs = await _context.NhaCungCaps!.ToListAsync();
            return _mapper.Map<List<NhaCungCapModel>>(nccs);
        }

        public async Task<NhaCungCapModel> GetNCCAsync(int mancc)
        {
            var ncc = await _context.NhaCungCaps!.FindAsync(mancc);
            return _mapper.Map<NhaCungCapModel>(ncc);
        }

        public async Task UpdateNCCAsync(int mancc, NhaCungCapModel model)
        {
            if (mancc == model.MaNCC)
            {
                var updatencc = _mapper.Map<NhaCungCap>(model);
                _context.NhaCungCaps!.Update(updatencc);
                await _context.SaveChangesAsync();
            }
        }
    }
}
