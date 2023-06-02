using AlmoxarifadoService.Interfaces;
using ApiAlmoxarifado.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace ApiAlmoxarifado.Controllers
{
    [Route("api/sr/[controller]")]
    [ApiController]
    public abstract class AlomoxarifadoBaseController<TService, TDtoRead, TDtoCreate, TDtoUpdate> : ControllerBase, IBaseController<TDtoRead, TDtoCreate, TDtoUpdate>
         where TService : IServiceBase
    {
        protected readonly TService _service;

        protected AlomoxarifadoBaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAsync()
        {
            try
            {
                var dtoRead = await _service.GetAllAsync<TDtoRead>();
                return Ok(dtoRead);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetByIdAsync))]
        public virtual async Task<IActionResult> GetByIdAsync(int? id)
        {
            try
            {
                var dtoRead = await _service.GetByIdAsync<TDtoRead>(id);

                if (dtoRead != null)
                    return Ok(dtoRead);

                return NotFound();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync([FromBody] TDtoCreate dtoCreate)
        {
            try
            {
                var dtoRead = await _service.AddAsync<TDtoRead, TDtoCreate>(dtoCreate);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = ((dynamic)dtoRead)?.Id }, dtoRead);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("list")]
        public virtual async Task<IActionResult> PostAsync([FromBody] IList<TDtoCreate> dtoCreate)
        {
            try
            {
                var dtoRead = await _service.AddRangeAsync<TDtoRead, TDtoCreate>(dtoCreate);
                return Ok(dtoRead);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> PutAsync([FromRoute] int? id, [FromBody] TDtoUpdate dtoUpdate)
        {
            try
            {
                await _service.UpdateAsync(id, dtoUpdate);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(int? id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
