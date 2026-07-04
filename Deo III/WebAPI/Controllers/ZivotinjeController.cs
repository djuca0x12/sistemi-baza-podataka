using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZivotinjeController : ControllerBase
    {
        [HttpGet("VratiSveZivotinje")]
        // koje sve kodove korisnik može da očekuje na webapi?
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSveZivotinje()
        {
            // dekonstrukcija na tri različita parametra
            var (isError, odeljenja, error) = await DataProvider.VratiSveZivotinje();

            if (isError)
            {
                // vraća se greška sa dobijenim status code-om
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(odeljenja);
        }

        [HttpGet("VratiZivotinju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiZivotinju(int id)
        {
            var (isError, odeljenja, error) = await DataProvider.VratiZivotinju(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(odeljenja);
        }

        [HttpPost("DodajZivotinju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajZivotinju([FromBody] ZivotinjeBasic z)
        {
            var (isError, uspesno, error) = await DataProvider.DodajZivotinju(z);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniZivotinju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> IzmeniZivotinju([FromBody] ZivotinjeBasic z)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniZivotinju(z);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiZivotinju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ObrisiZivotinju(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiZivotinju(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("ProveriBrojUha")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ProveriBrojUha([FromQuery] string brojUha, [FromQuery] int trenutniId = 0)
        {
            // Pozivamo asinhranu metodu iz DataProvider-a
            var (isError, postoji, error) = await DataProvider.DaLiPostojiZivotinjaSaBrojemUha(brojUha, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            // Vraća true ako broj uha već postoji kod neke druge životinje, inače false
            return Ok(postoji);
        }
    }
}
