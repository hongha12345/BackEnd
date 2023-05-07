using BARBEER_SHOP.Models;
using BARBEER_SHOP.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BARBEER_SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaCungCapsController : ControllerBase
    {
        private readonly INhaCungCapRepository _nhacungcaprepo;

        public NhaCungCapsController(INhaCungCapRepository repo)
        {
            _nhacungcaprepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNhaCungCaps()
        {
            try
            {
                return Ok(await _nhacungcaprepo.GetAllNCCsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{mancc}")]
        public async Task<IActionResult> GetNhaCungCap(int mancc)
        {
            var nhacungcap = await _nhacungcaprepo.GetNCCAsync(mancc);

            if (nhacungcap == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(nhacungcap);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewNhaCungCap(NhaCungCapModel model)
        {
            try
            {
                var newnhacungcap = await _nhacungcaprepo.AddNCCAsync(model);
                var nhacungcap = await _nhacungcaprepo.GetNCCAsync(newnhacungcap);

                if (nhacungcap == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(nhacungcap);
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{mancc}")]
        public async Task<IActionResult> UpdateNhaCungCap(int mancc, NhaCungCapModel model)
        {
            if (mancc != model.MaNCC)
            {
                return NotFound();
            }
            else
            {
                await _nhacungcaprepo.UpdateNCCAsync(mancc, model);
                return Ok();
            }
        }

        [HttpDelete("{mancc}")]
        public async Task<ActionResult> DeleteNhaCungCap(int mancc)
        {
            await _nhacungcaprepo.DeleteNCCAsync(mancc);
            return Ok();
        }
    }
}
