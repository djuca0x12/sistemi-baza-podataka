using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PovrceController : ControllerBase
    {
        [HttpGet("VratiSvoPovrce")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSvoPovrce()
        {
            var (isError, povrce, error) = await DataProvider.VratiSvoPovrce();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(povrce);
        }

        [HttpGet("VratiPovrce/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiPovrce(int id)
        {
            var (isError, povrce, error) = await DataProvider.VratiPovrce(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(povrce);
        }

        [HttpPost("DodajPovrce")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajPovrce([FromBody] PovrceBasic p)
        {
            var (isError, uspesno, error) = await DataProvider.DodajPovrce(p);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniPovrce")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> IzmeniPovrce([FromBody] PovrceBasic p)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniPovrce(p);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiPovrce/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ObrisiPovrce(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiPovrce(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }
    }
}
