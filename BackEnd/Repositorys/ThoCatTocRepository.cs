using AutoMapper;
using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace BARBEER_SHOP.Repositorys
{
    public class ThoCatTocRepository : IThoCatTocRepository
    {
        private readonly BarberShopContext _context;
        private readonly IMapper _mapper;

        public ThoCatTocRepository(BarberShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddThoCatTocAsync(ThoCatTocModel model)
        {
            var newthocattoc = _mapper.Map<ThoCatToc>(model);
            _context.ThoCatTocs!.Add(newthocattoc);
            await _context.SaveChangesAsync();
            return newthocattoc.MaTCT;
        }

        public async Task DeleteThoCatTocAsync(int matct)
        {
            var deletethocattoc = _context.ThoCatTocs!.SingleOrDefault(a => a.MaTCT == matct);
            if (deletethocattoc != null)
            {
                _context.ThoCatTocs!.Remove(deletethocattoc);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ThoCatTocModel>> GetAllThoCatTocsAsync()
        {
            var thocattocs = await _context.ThoCatTocs!.ToListAsync();
            return _mapper.Map<List<ThoCatTocModel>>(thocattocs);
        }

        public async Task<ThoCatTocModel> GetThoCatTocAsync(int matct)
        {
            var thocattoc = await _context.ThoCatTocs!.FindAsync(matct);
            return _mapper.Map<ThoCatTocModel>(thocattoc);
        }

        public async Task UpdateThoCatTocAsync(int matct, ThoCatTocModel model)
        {
            if (matct == model.MaTCT)
            {
                var updatethocattoc = _mapper.Map<ThoCatToc>(model);
                _context.ThoCatTocs!.Update(updatethocattoc);
                await _context.SaveChangesAsync();
            }
        }
    }
}
