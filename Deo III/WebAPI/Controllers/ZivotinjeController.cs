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

    }
}