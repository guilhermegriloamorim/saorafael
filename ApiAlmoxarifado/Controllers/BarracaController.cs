using AlmoxarifadoService.Dominio.DTO;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    public class BarracaController : AlomoxarifadoBaseController<IServiceBarraca, BarracaDtoRead, BarracaDtoCreate, BarracaDtoUpdate>
    {
        public BarracaController(IServiceBarraca barracaService) : base(barracaService)
        {
        }
    }
}
