﻿namespace AlmoxarifadoService.Interfaces
{
    public interface IServiceBase
    {
        Task<TDto> GetByIdAsync<TDto>(Guid id);
        Task<IEnumerable<TDto>> GetAllAsync<TDto>();
        Task<TDtoRead> AddAsync<TDtoRead, TDtoCreate>(TDtoCreate dto);
        Task<IList<TDtoRead>> AddRangeAsync<TDtoRead, TDtoCreate>(IList<TDtoCreate> dto);
        Task<TDto> UpdateAsync<TDto>(Guid id, TDto dto);
        Task<bool> DeleteAsync(Guid id);
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
    }
    //UnidadeMedidaViewModel
    public interface IServiceUnidadeMedidaViewModel : IServiceBase
    {
    }
}
