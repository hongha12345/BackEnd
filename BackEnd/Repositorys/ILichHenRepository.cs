using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface ILichHenRepository
    {
        public Task<List<LichHenModel>> GetAllLichHensAsync();
        public Task<LichHenModel> GetLichHenAsync(int malh);
        public Task<int> AddLichHenAsync(LichHenModel model);
        public Task UpdateLichHenAsync(int malh, LichHenModel model);
        public Task DeleteLichHenAsync(int malh);
    }
}
