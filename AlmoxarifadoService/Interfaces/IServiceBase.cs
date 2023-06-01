namespace AlmoxarifadoService.Interfaces
{
    public interface IServiceBase
    {
        Task<TDto> GetByIdAsync<TDto>(Guid id);
        Task<IEnumerable<TDto>> GetAllAsync<TDto>();
        Task<TDtoRead> AddAsync<TDtoRead,TDtoCreate>(TDtoCreate dto);
        Task<TDto> UpdateAsync<TDto>(Guid id, TDto dto);
        Task<bool> DeleteAsync(Guid id);
    }

    //BarracaService
    public interface IServiceBarraca : IServiceBase
    {
    }

    //ColaboradorService
    public interface IColaboradorService : IServiceBase
    {
    }

    //ItemService
    public interface IServiceItem : IServiceBase
    {
    }
     
    //ItemSaidaService
    public interface IServiceItemSaida : IServiceBase
    {
    }

    //ItemEntradaService
    public interface IServiceItemEntrada : IServiceBase
    {
    }

    //ItemSaidaViewModel
    public interface IServiceItemSaidaViewModel : IServiceBase
    {
    }

    //ItemEntradaViewModel
    public interface IServiceItemEntradaViewModel : IServiceBase
    {
    }

    //UnidadeMedidaService
    public interface IServiceUnidadeMedidaViewModel : IServiceBase
    {
    }
}
