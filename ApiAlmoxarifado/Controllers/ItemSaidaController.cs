using AlmoxarifadoService.Dominio.DTO;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    public class ItemSaidaController : AlomoxarifadoBaseController<IServiceItemSaida, ItemSaidaDtoRead, ItemSaidaDtoCreate, ItemSaidaDtoUpdate>
    {
        public ItemSaidaController(IServiceItemSaida itemSaidaService) : base(itemSaidaService)
        {
        }
    }
}
