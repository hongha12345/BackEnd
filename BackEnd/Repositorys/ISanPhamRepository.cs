using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface ISanPhamRepository
    {
        public Task<List<SanPhamModel>> GetAllSanPhamsAsync();
        public Task<SanPhamModel> GetSanPhamAsync(int masp);
        public Task<int> AddSanPhamAsync(SanPhamModel model);
        public Task UpdateSanPhamAsync(int masp, SanPhamModel model);
        public Task DeleteSanPhamAsync(int masp);
    }
}
