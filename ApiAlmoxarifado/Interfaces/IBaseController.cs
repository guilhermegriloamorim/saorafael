using Microsoft.AspNetCore.Mvc;
namespace ApiAlmoxarifado.Interfaces
{
    public interface IBaseController<TDtoRead, TDtoCreate, TDtoUpdate>
    {
        public Task<IActionResult> GetAsync();
        public Task<IActionResult> GetByIdAsync(int? id);
        public Task<IActionResult> PostAsync([FromBody] TDtoCreate dtoCreate);
        public Task<IActionResult> PostAsync([FromBody] IList<TDtoCreate> dtoCreate);
        public Task<IActionResult> PutAsync([FromRoute] int? id, [FromBody] TDtoUpdate dtoUpdate);
        public Task<IActionResult> DeleteAsync(int? id);
    }
}
