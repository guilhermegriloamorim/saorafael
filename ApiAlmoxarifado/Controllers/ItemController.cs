using AlmoxarifadoService.Dominio.DTO;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    public class ItemController : AlomoxarifadoBaseController<IServiceItem, ItemDtoRead, ItemDtoCreate, ItemDtoUpdate>
    {
        public ItemController(IServiceItem service) : base(service)
        {
        }
    }   
}
