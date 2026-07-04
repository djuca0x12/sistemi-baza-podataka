using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KoristiZaController : ControllerBase
    {
        [HttpGet("VratiPregledKoriscenja")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiPregledKoriscenja()
        {
            var (isError, pregled, error) = await DataProvider.VratiPregledKoriscenja();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(pregled);
        }

        [HttpPost("PoveziMehanizacijuIPrinos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> PoveziMehanizacijuIPrinos([FromQuery] int idMehanizacija, [FromQuery] int idPrinos, [FromQuery] DateTime datumOd)
        {
            var (isError, uspesno, error) = await DataProvider.PoveziMehanizacijuIPrinos(idMehanizacija, idPrinos, datumOd);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("VratiTipMehanizacije/{idMehanizacija}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiTipMehanizacije(int idMehanizacija)
        {
            var (isError, tip, error) = await DataProvider.VratiTipMehanizacije(idMehanizacija);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(new { Tip = tip });
        }

        [HttpPut("AzurirajKoriscenje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> AzurirajKoriscenje([FromBody] AzurirajKoriscenjeDto dto)
        {
            var (isError, uspesno, error) = await DataProvider.AzurirajKoriscenje(
                dto.StariIdMehanizacija, 
                dto.IdPrinos, 
                dto.DatumOd, 
                dto.NoviIdMehanizacija, 
                dto.NoviDatumDo
            );

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (!uspesno)
            {
                return BadRequest("Zapis o korišćenju nije pronađen ili izmena nije uspela.");
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiKoriscenje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiKoriscenje([FromQuery] int idMehanizacija, [FromQuery] int idPrinos, [FromQuery] DateTime datumOd)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiKoriscenje(idMehanizacija, idPrinos, datumOd);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 404, error?.Message);
            }

            return Ok(uspesno);
        }
    }

    public class AzurirajKoriscenjeDto
    {
        public int StariIdMehanizacija { get; set; }
        public int IdPrinos { get; set; }
        public DateTime DatumOd { get; set; }
        public int NoviIdMehanizacija { get; set; }
        public DateTime? NoviDatumDo { get; set; }
    }
}