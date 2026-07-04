using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZitariceController : ControllerBase
    {
        [HttpGet("VratiSveZitarice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSveZitarice()
        {
            var (isError, zitarice, error) = await DataProvider.VratiSveZitarice();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(zitarice);
        }

        [HttpGet("VratiZitaricu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiZitaricu(int id)
        {
            var (isError, zitarica, error) = await DataProvider.VratiZitaricu(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(zitarica);
        }

        

        [HttpPost("DodajZitaricu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajZitaricu([FromBody] ZitariceBasic z)
        {
            var (isError, uspesno, error) = await DataProvider.DodajZitaricu(z);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniZitaricu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> IzmeniZitaricu([FromBody] ZitariceBasic z)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniZitaricu(z);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiZitaricu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ObrisiZitaricu(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiZitaricu(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }


        [HttpGet("ProveriPostojanjeUseva")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ProveriPostojanjeUseva([FromQuery] string naziv, [FromQuery] string lokacija, [FromQuery] int trenutniId = 0)
        {
            // Pozivamo asinhronu metodu iz DataProvider-a
            var (isError, postoji, error) = await DataProvider.DaLiPostojiUsevSaNazivomILokacijom(naziv, lokacija, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            // Vraća true ako već postoji usev sa tim nazivom ili lokacijom, u suprotnom false
            return Ok(postoji);
        }
    }
}