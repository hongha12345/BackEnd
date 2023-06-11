using BackEnd.Models;
using BackEnd.Repositorys;
using BARBEER_SHOP.Models;
using BARBEER_SHOP.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiNhanhsController : ControllerBase
    {
        private readonly IChiNhanhRepository _chinhanhrepo;

        public ChiNhanhsController(IChiNhanhRepository repo)
        {
            _chinhanhrepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllChiNhanhs()
        {
            try
            {
                return Ok(await _chinhanhrepo.GetAllChiNhanhsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{macn}")]
        public async Task<IActionResult> GetChiNhanh(int macn)
        {
            var chinhanh = await _chinhanhrepo.GetChiNhanhAsync(macn);

            if (chinhanh == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(chinhanh);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewChiNhanh(ChiNhanhModel model)
        {
            try
            {
                var newchinhanh = await _chinhanhrepo.AddChiNhanhAsync(model);
                var chinhanh = await _chinhanhrepo.GetChiNhanhAsync(newchinhanh);

                if (chinhanh == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(chinhanh);
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{macn}")]
        public async Task<IActionResult> UpdateChiNhanh(int macn, ChiNhanhModel model)
        {
            if (macn != model.MaCN)
            {
                return NotFound();
            }
            else
            {
                await _chinhanhrepo.UpdateChiNhanhAsync(macn, model);
                return Ok();
            }
        }

        [HttpDelete("{macn}")]
        public async Task<ActionResult> DeleteChiNhanh(int macn)
        {
            await _chinhanhrepo.DeleteChiNhanhAsync(macn);
            return Ok();
        }
    }
}
