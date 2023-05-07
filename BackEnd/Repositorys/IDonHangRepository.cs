using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface IDonHangRepository
    {
        public Task<List<DonHangModel>> GetAllDonHangsAsync();
        public Task<DonHangModel> GetDonHangAsync(int madh);
        public Task<int> AddDonHangAsync(DonHangModel model);
        public Task UpdateDonHangAsync(int madh, DonHangModel model);
        public Task DeleteDonHangAsync(int madh);
    }
}
