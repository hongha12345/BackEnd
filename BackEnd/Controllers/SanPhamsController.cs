using BARBEER_SHOP.Models;
using BARBEER_SHOP.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BARBEER_SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamsController : ControllerBase
    {
        private readonly ISanPhamRepository _sanphamrepo;

        public SanPhamsController(ISanPhamRepository repo)
        {
            _sanphamrepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSanPhams()
        {
            try
            {
                return Ok(await _sanphamrepo.GetAllSanPhamsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{masp}")]
        public async Task<IActionResult> GetSanPham(int masp)
        {
            var sanpham = await _sanphamrepo.GetSanPhamAsync(masp);

            if (sanpham == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(sanpham);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSanPham(SanPhamModel model)
        {
            try
            {
                var newsanpham = await _sanphamrepo.AddSanPhamAsync(model);
                var sanpham = await _sanphamrepo.GetSanPhamAsync(newsanpham);

                if (sanpham == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(sanpham);
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{masp}")]
        public async Task<IActionResult> UpdateSanPham(int masp, SanPhamModel model)
        {
            if (masp != model.MaSP)
            {
                return NotFound();
            }
            else
            {
                await _sanphamrepo.UpdateSanPhamAsync(masp, model);
                return Ok();
            }
        }

        [HttpDelete("{masp}")]
        public async Task<ActionResult> DeleteSanPham(int masp)
        {
            await _sanphamrepo.DeleteSanPhamAsync(masp);
            return Ok();
        }
    }
}
