using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VocnjaciController : ControllerBase
    {
        [HttpGet("VratiSveVocnjake")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSveVocnjake()
        {
            var (isError, vocnjaci, error) = await DataProvider.VratiSveVocnjake();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(vocnjaci);
        }

        [HttpGet("VratiVocnjak/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiVocnjak(int id)
        {
            var (isError, vocnjak, error) = await DataProvider.VratiVocnjak(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(vocnjak);
        }

        [HttpPost("DodajVocnjak")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajVocnjak([FromBody] VocnjaciBasic v)
        {
            var (isError, uspesno, error) = await DataProvider.DodajVocnjak(v);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniVocnjak")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> IzmeniVocnjak([FromBody] VocnjaciBasic v)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniVocnjak(v);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiVocnjak/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ObrisiVocnjak(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiVocnjak(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }
    }
}