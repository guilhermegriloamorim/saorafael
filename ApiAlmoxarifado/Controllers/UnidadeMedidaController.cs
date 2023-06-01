using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Data;
using AlmoxarifadoRepositories.Interfaces;
using AlmoxarifadoService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifado.Controllers
{

    //controller unidade de medida sem mapper
    public class UnidadeMedidaController : AlomoxarifadoBaseController<IServiceUnidadeMedidaViewModel, UnidadeMedidaViewModel, UnidadeMedidaViewModel, UnidadeMedidaViewModel>
    {
        public UnidadeMedidaController(IServiceUnidadeMedidaViewModel unidadeMedidaService) : base(unidadeMedidaService)
        {
        }
    }
    //[Route("api/[controller]")]
    //[ApiController]
    //public class UnidadeMedidaController : ControllerBase
    //{
    //    private AlmoxarifadoDbContext _context;


    //    public UnidadeMedidaController(AlmoxarifadoDbContext context) : base()
    //    {
    //        _context = context;
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> GetUnidadeMedidas() 
    //    {
    //        try
    //        {
    //            var model = await _context.UnidadeMedidaViewModel.OrderBy(e => e.DESCRICAO).ToListAsync();
    //            return Ok(model);
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }
    //}
}
