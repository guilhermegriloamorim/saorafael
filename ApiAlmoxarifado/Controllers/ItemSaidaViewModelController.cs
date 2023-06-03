using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    //itemSaidaViewModel controller
    public class ItemSaidaViewModelController : AlomoxarifadoBaseController<IServiceItemSaidaViewModel, ItemSaidaViewModel, ItemSaidaViewModel, ItemSaidaViewModel>
    {
        public ItemSaidaViewModelController(IServiceItemSaidaViewModel serviceItemSaidaViewModel) : base(serviceItemSaidaViewModel)
        {
        }

        [HttpGet("filtter/{barraca?}/{data?}")]
        public virtual async Task<IActionResult> GetAsync(string? barraca, string? data)
        {
            try
            {
                var dtoRead = await _service.GetFillterAsync(barraca, data);
                return Ok(dtoRead);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
