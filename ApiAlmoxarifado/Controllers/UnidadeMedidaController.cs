using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    public class UnidadeMedidaController : AlomoxarifadoBaseController<IServiceUnidadeMedidaViewModel, UnidadeMedidaViewModel, UnidadeMedidaViewModel, UnidadeMedidaViewModel>
    {
        public UnidadeMedidaController(IServiceUnidadeMedidaViewModel unidadeMedidaService) : base(unidadeMedidaService)
        {
        }
    }
}
