using Almoxarifado.Dominio.ViewModel;

namespace AlmoxarifadoService.Interfaces
{
    public interface IServiceBase
    {
        Task<TDto> GetByIdAsync<TDto>(int? id);
        Task<IEnumerable<TDto>> GetAllAsync<TDto>();
        Task<TDtoRead> AddAsync<TDtoRead, TDtoCreate>(TDtoCreate dto);
        Task<IList<TDtoRead>> AddRangeAsync<TDtoRead, TDtoCreate>(IList<TDtoCreate> dto);
        Task<TDto> UpdateAsync<TDto>(int? id, TDto dto);
        Task<bool> DeleteAsync(int? id);
    }

    //Barraca
    public interface IServiceBarraca : IServiceBase
    {
    }
    //Item
    public interface IServiceItem : IServiceBase
    {
    }
    //ItemSaida
    public interface IServiceItemSaida : IServiceBase
    {
    }
    //ItemEntrada
    public interface IServiceItemEntrada : IServiceBase
    {
    }
    //ItemSaida
    public interface IServiceItemSaidaViewModel : IServiceBase
    {
        Task<IList<ItemSaidaViewModel>> GetFillterAsync(string? barraca, string? data);
    }
    //UnidadeMedidaViewModel
    public interface IServiceUnidadeMedidaViewModel : IServiceBase
    {
    }
}
