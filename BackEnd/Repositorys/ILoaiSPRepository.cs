using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface ILoaiSPRepository
    {
        public Task<List<LoaiSPModel>> GetAllLoaiSPsAsync();
        public Task<LoaiSPModel> GetLoaiSPAsync(int malsp);
        public Task<int> AddLoaiSPAsync(LoaiSPModel model);
        public Task UpdateLoaiSPAsync(int malsp, LoaiSPModel model);
        public Task DeleteLoaiSPAsync(int malsp);
    }
}
