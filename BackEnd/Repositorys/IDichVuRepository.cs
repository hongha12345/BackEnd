using BARBEER_SHOP.DATA;
using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface IDichVuRepository
    {
        public Task<List<DichVuModel>> GetAllDichVusAsync();
        public Task<DichVuModel> GetDichVuAsync(int madv);
        public Task<int> AddDichVuAsync(DichVuModel model);
        public Task UpdateDichVuAsync(int madv, DichVuModel model);
        public Task DeleteDichVuAsync(int madv);
    }
}
