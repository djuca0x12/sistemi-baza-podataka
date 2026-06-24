using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdajaController : ControllerBase
    {
        [HttpGet("VratiSveProdaje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSveProdaje()
        {
            var (isError, prodaje, error) = await DataProvider.VratiSveProdaje();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(prodaje);
        }

        [HttpGet("VratiProdajuPoId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiProdajuPoId(int id)
        {
            var (isError, prodaja, error) = await DataProvider.VratiProdajuPoId(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (prodaja == null)
            {
                return NotFound("Prodaja sa zadatim ID-em ne postoji.");
            }

            return Ok(prodaja);
        }

        [HttpPost("DodajProdaju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajProdaju([FromBody] ProdajaBasic p)
        {
            var (isError, uspesno, error) = await DataProvider.DodajProdaju(p);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniProdaju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> IzmeniProdaju([FromBody] ProdajaBasic p)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniProdaju(p);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiProdaju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiProdaju(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiProdaju(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("ProveriDaLiBrojFakturePostoji/{brojFakture}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ProveriDaLiBrojFakturePostoji(string brojFakture, [FromQuery] int trenutniId = 0)
        {
            var (isError, postoji, error) = await DataProvider.ProveriDaLiBrojFakturePostoji(brojFakture, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 403, error?.Message);
            }

            return Ok(postoji);
        }

        [HttpGet("DaLiImaDovoljnoPrinosa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DaLiImaDovoljnoPrinosa([FromQuery] int idPrinosa, [FromQuery] decimal kolicinaZaProdaju, [FromQuery] string jedinicaSaForme)
        {
            var (isError, imaDovoljno, error) = await DataProvider.DaLiImaDovoljnoPrinosa(idPrinosa, kolicinaZaProdaju, jedinicaSaForme);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 403, error?.Message);
            }

            return Ok(imaDovoljno);
        }
    }
}