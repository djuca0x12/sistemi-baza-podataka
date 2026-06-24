using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrinosController : ControllerBase
    {
        [HttpGet("VratiSvePrinose")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSvePrinose()
        {
            var (isError, prinosi, error) = await DataProvider.VratiSvePrinose();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(prinosi);
        }

        [HttpGet("VratiPrinosPoId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiPrinosPoId(int id)
        {
            var (isError, prinos, error) = await DataProvider.VratiPrinosPoId(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (prinos == null)
            {
                return NotFound("Prinos sa zadatim ID-em ne postoji.");
            }

            return Ok(prinos);
        }

        [HttpPost("DodajPrinos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajPrinos([FromBody] PrinosBasic p)
        {
            var (isError, uspesno, error) = await DataProvider.DodajPrinos(p);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniPrinos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> IzmeniPrinos([FromBody] PrinosBasic p)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniPrinos(p);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiPrinos/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiPrinos(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiPrinos(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("ProveriDaLiTipPostoji/{tip}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ProveriDaLiTipPostoji(string tip, [FromQuery] int trenutniId = 0)
        {
            var (isError, postoji, error) = await DataProvider.ProveriDaLiTipPostoji(tip, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 403, error?.Message);
            }

            return Ok(postoji);
        }
    }
}