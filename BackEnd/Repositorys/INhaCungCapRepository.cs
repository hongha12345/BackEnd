using BARBEER_SHOP.Models;

namespace BARBEER_SHOP.Repositorys
{
    public interface INhaCungCapRepository
    {
        public Task<List<NhaCungCapModel>> GetAllNCCsAsync();
        public Task<NhaCungCapModel> GetNCCAsync(int mancc);
        public Task<int> AddNCCAsync(NhaCungCapModel model);
        public Task UpdateNCCAsync(int mancc, NhaCungCapModel model);
        public Task DeleteNCCAsync(int mancc);
    }
}
