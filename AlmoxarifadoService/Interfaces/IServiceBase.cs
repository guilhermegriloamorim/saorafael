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
    public interface IBarracaService : IServiceBase
    {
    }

    //ColaboradorService
    public interface IColaboradorService : IServiceBase
    {
    }

    //ItemService
    public interface IItemService : IServiceBase
    {
    }
     
    //ItemSaidaService
    public interface IItemSaidaService : IServiceBase
    {
    }

    //ItemEntradaService
    public interface IItemEntradaService : IServiceBase
    {
    }

    //ItemSaidaViewModel
    public interface IItemSaidaViewModel : IServiceBase
    {
    }

    //ItemEntradaViewModel
    public interface IItemEntradaViewModel : IServiceBase
    {
    }
}
