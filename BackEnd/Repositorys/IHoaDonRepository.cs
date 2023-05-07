using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface IHoaDonRepository
    {
        public Task<List<HoaDonModel>> GetAllHoaDonsAsync();
        public Task<HoaDonModel> GetHoaDonAsync(int mahd);
        public Task<int> AddHoaDonAsync(HoaDonModel model);
        public Task UpdateHoaDonAsync(int mahd, HoaDonModel model);
        public Task DeleteHoaDonAsync(int mahd);
    }
}
