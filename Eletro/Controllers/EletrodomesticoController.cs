using Eletro.DTOs.Request;
using Eletro.DTOs.Response;
using Eletro.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eletro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EletrodomesticoController : ControllerBase
    {
        private readonly IEletrodomesticoService _service;

        public EletrodomesticoController(IEletrodomesticoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EletrodomesticoResponseDto>>> GetAllAsync()
        {
            var eletros = await _service.GetAllAsync();
            return Ok(eletros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EletrodomesticoResponseDto>> GetByIdAsync(int id)
        {
            var eletro = await _service.GetByIdAsync(id);

            if (eletro == null) return NotFound();

            return Ok(eletro);
        }

        [HttpPost]
        public async Task<ActionResult<EletrodomesticoResponseDto>> CreateAsync([FromBody] EletrodomesticoRequestDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EletrodomesticoResponseDto>> UpdateAsync(int id, EletrodomesticoRequestDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);

            if (updated == null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var deleted = await _service.DeleteAsync(id);

            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
