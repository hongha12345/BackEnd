using BARBEER_SHOP.Models;
using BARBEER_SHOP.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BARBEER_SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangsController : ControllerBase
    {
        private readonly IDonHangRepository _donhangrepo;

        public DonHangsController(IDonHangRepository repo)
        {
            _donhangrepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDonHangs()
        {
            try
            {
                return Ok(await _donhangrepo.GetAllDonHangsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{madh}")]
        public async Task<IActionResult> GetDonHang(int madh)
        {
            var donhang = await _donhangrepo.GetDonHangAsync(madh);

            if (donhang == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(donhang);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewDonHang(DonHangModel model)
        {
            try
            {
                var newdonhang = await _donhangrepo.AddDonHangAsync(model);
                var donhang = await _donhangrepo.GetDonHangAsync(newdonhang);

                if (donhang == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(donhang);
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{madh}")]
        public async Task<IActionResult> UpdateDonHang(int madh, DonHangModel model)
        {
            if (madh != model.MaDH)
            {
                return NotFound();
            }
            else
            {
                await _donhangrepo.UpdateDonHangAsync(madh, model);
                return Ok();
            }
        }

        [HttpDelete("{madh}")]
        public async Task<ActionResult> DeleteDonHang(int madh)
        {
            await _donhangrepo.DeleteDonHangAsync(madh);
            return Ok();
        }
    }
}
