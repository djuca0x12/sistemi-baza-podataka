using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodeController : ControllerBase
    {
        [HttpPost("DodajPrinosIKategoriju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajPrinosIKategoriju([FromBody] DodajPrinosIKategorijuDto dto)
        {
            var (isError, uspesno, error) = await DataProvider.DodajPrinosIKategoriju(dto.PrinosDTO, dto.IdKategorije);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("DohvatiIdKategorije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DohvatiIdKategorije([FromQuery] int idEntiteta, [FromQuery] string tipEntiteta)
        {
            var (isError, kategorijaId, error) = await DataProvider.DohvatiIdKategorije(idEntiteta, tipEntiteta);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(new { KategorijaId = kategorijaId });
        }

        [HttpDelete("ObrisiProizvodnuVezu/{proizvodeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiProizvodnuVezu(int proizvodeId)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiProizvodnuVezu(proizvodeId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (!uspesno)
            {
                return BadRequest("Proizvodna veza sa zadatim ID-em ne postoji.");
            }

            return Ok(uspesno);
        }

        [HttpGet("VratiSveProizvodneIzvestaje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSveProizvodneIzvestaje()
        {
            var (isError, izvestaji, error) = await DataProvider.VratiSveProizvodneIzvestaje();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(izvestaji);
        }
    }

    /// <summary>
    /// Pomoćni DTO za prihvat podataka pri kreiranju prinosa i vezivanju za kategoriju
    /// </summary>
    public class DodajPrinosIKategorijuDto
    {
        public PrinosBasic PrinosDTO { get; set; } = null!;
        public int IdKategorije { get; set; }
    }
}