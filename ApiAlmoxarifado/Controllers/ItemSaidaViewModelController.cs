using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    //itemSaidaViewModel controller
    public class ItemSaidaViewModelController : AlomoxarifadoBaseController<IServiceItemSaidaViewModel, ItemSaidaViewModel, ItemSaidaViewModel, ItemSaidaViewModel>
    {
        public ItemSaidaViewModelController(IServiceItemSaidaViewModel serviceItemSaidaViewModel) : base(serviceItemSaidaViewModel)
        {
        }
    }
}
