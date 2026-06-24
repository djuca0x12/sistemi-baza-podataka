using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubvencijaController : ControllerBase
    {
        [HttpGet("VratiSveSubvencije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSveSubvencije()
        {
            var (isError, subvencije, error) = await DataProvider.VratiSveSubvencije();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(subvencije);
        }

        [HttpPost("DodajSubvenciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajSubvenciju([FromBody] SubvencijaBasic s)
        {
            var (isError, uspesno, error) = await DataProvider.DodajSubvenciju(s);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("AzurirajSubvenciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> AzurirajSubvenciju([FromBody] SubvencijaBasic s)
        {
            var (isError, uspesno, error) = await DataProvider.AzurirajSubvenciju(s);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (!uspesno)
            {
                return BadRequest("Subvencija sa zadatim ID-em nije pronađena.");
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiSubvenciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiSubvenciju(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiSubvenciju(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (!uspesno)
            {
                return BadRequest("Subvencija sa zadatim ID-em ne postoji.");
            }

            return Ok(uspesno);
        }

        [HttpGet("DaLiBrojResenjaPostoji/{brojResenja}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DaLiBrojResenjaPostoji(string brojResenja, [FromQuery] int? trenutniId = null)
        {
            var (isError, postoji, error) = await DataProvider.DaLiBrojResenjaPostoji(brojResenja, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 403, error?.Message);
            }

            return Ok(postoji);
        }
    }
}