using BARBEER_SHOP.Models;
using BARBEER_SHOP.DATA;

namespace BARBEER_SHOP.Repositorys
{
    public interface IThoCatTocRepository
    {
        public Task<List<ThoCatTocModel>> GetAllThoCatTocsAsync();
        public Task<ThoCatTocModel> GetThoCatTocAsync(int matct);
        public Task<int> AddThoCatTocAsync(ThoCatTocModel model);
        public Task UpdateThoCatTocAsync(int matct, ThoCatTocModel model);
        public Task DeleteThoCatTocAsync(int matct);
    }
}
