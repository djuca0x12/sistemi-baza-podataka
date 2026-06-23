using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KrmnoBiljeController : ControllerBase
    {
        [HttpGet("VratiSvoKrmnoBilje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSvoKrmnoBilje()
        {
            var (isError, krmnoBilje, error) = await DataProvider.VratiSvoKrmnoBilje();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(krmnoBilje);
        }

        [HttpGet("VratiKrmnoBilje/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiKrmnoBilje(int id)
        {
            var (isError, krmnoBilje, error) = await DataProvider.VratiKrmnoBilje(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(krmnoBilje);
        }

        [HttpPost("DodajKrmnoBilje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajKrmnoBilje([FromBody] KrmnoBiljeBasic k)
        {
            var (isError, uspesno, error) = await DataProvider.DodajKrmnoBilje(k);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniKrmnoBilje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> IzmeniKrmnoBilje([FromBody] KrmnoBiljeBasic z)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniKrmnoBilje(z);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiKrmnoBilje/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ObrisiKrmnoBilje(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiKrmnoBilje(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }
    }
}