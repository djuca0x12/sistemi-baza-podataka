using Microsoft.AspNetCore.Mvc;
using PoljoprivrednoGazdinstvoLibrary;
using WebAPI.Code;
using PoljoprivrednoGazdinstvoLibrary.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MehanizacijaController : ControllerBase
    {
        #region  Traktori
        
        [HttpGet("UcitajTraktore")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> UcitajTraktore()
        {
            var (isError, traktori, error) = await DataProvider.UcitajTraktore();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(traktori);
        }

        [HttpGet("VratiTraktorPoId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiTraktorPoId(int id)
        {
            var (isError, traktor, error) = await DataProvider.VratiTraktorPoId(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (traktor == null)
            {
                return NotFound("Traktor sa zadatim ID-em ne postoji.");
            }

            return Ok(traktor);
        }

        [HttpPost("DodajTraktor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajTraktor([FromBody] TraktorBasic t)
        {
            var (isError, uspesno, error) = await DataProvider.DodajTraktor(t);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniTraktor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> IzmeniTraktor([FromBody] TraktorBasic t)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniTraktor(t);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiTraktor/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiTraktor(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiTraktor(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("ProveriDaLiBrojSasijePostoji/{brojSasije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ProveriDaLiBrojSasijePostoji(string brojSasije, [FromQuery] int trenutniId = 0)
        {
            var (isError, postoji, error) = await DataProvider.ProveriDaLiBrojSasijePostoji(brojSasije, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 403, error?.Message);
            }

            return Ok(postoji);
        }

        #endregion

        #region Mašine / Prskalice

        [HttpGet("VratiSvePrskalice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiSvePrskalice()
        {
            var (isError, masine, error) = await DataProvider.VratiSvePrskalice();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(masine);
        }

        [HttpGet("VratiMasinuPoId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> VratiMasinuPoId(int id)
        {
            var (isError, masina, error) = await DataProvider.VratiMasinuPoId(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (masina == null)
            {
                return NotFound("Mašina sa zadatim ID-em ne postoji.");
            }

            return Ok(masina);
        }

        [HttpPost("DodajMasinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DodajMasinu([FromBody] MasinaBasic m)
        {
            var (isError, uspesno, error) = await DataProvider.DodajMasinu(m);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpPut("IzmeniMasinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> IzmeniMasinu([FromBody] MasinaBasic m)
        {
            var (isError, uspesno, error) = await DataProvider.IzmeniMasinu(m);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpDelete("ObrisiMasinu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ObrisiMasinu(int id)
        {
            var (isError, uspesno, error) = await DataProvider.ObrisiMasinu(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(uspesno);
        }

        [HttpGet("ProveriDaLiBrojSasijePostojiZaMasinu/{brojSasije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> ProveriDaLiBrojSasijePostojiZaMasinu(string brojSasije, [FromQuery] int trenutniId = 0)
        {
            var (isError, postoji, error) = await DataProvider.ProveriDaLiBrojSasijePostojiZaMasinu(brojSasije, trenutniId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 403, error?.Message);
            }

            return Ok(postoji);
        }

        #endregion

    }
}