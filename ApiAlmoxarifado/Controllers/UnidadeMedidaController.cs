using AlmoxarifadoRepositories.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadeMedidaController : ControllerBase
    {
        private AlmoxarifadoDbContext _context;


        public UnidadeMedidaController(AlmoxarifadoDbContext context) : base()
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUnidadeMedidas() 
        {
            try
            {
                var model = await _context.UnidadeMedidaViewModel.OrderBy(e => e.DESCRICAO).ToListAsync();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
