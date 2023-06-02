using AlmoxarifadoService.Dominio.DTO;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    public class ItemEntradaController : AlomoxarifadoBaseController<IServiceItemEntrada, ItemEntradaDtoRead, ItemEntradaDtoCreate, ItemEntradaDtoUpdate>
    {
        public ItemEntradaController(IServiceItemEntrada service) : base(service)
        {
        }
    }
}
