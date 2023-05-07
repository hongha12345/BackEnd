using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface ILoaiDVRepository
    {
        public Task<List<LoaiDVModel>> GetAllLoaiDVsAsync();
        public Task<LoaiDVModel> GetLoaiDVAsync(int maldv);
        public Task<int> AddLoaiDVAsync(LoaiDVModel model);
        public Task UpdateLoaiDVAsync(int maldv, LoaiDVModel model);
        public Task DeleteLoaiDVAsync(int maldv);
    }
}
