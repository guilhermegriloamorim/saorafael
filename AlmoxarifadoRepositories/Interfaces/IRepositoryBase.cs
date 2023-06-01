using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;

namespace AlmoxarifadoRepositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
    }

    //Barraca
    public interface IBarracaRepository : IRepositoryBase<Barraca>
    {
    }

    //Item
    public interface IItemRepository : IRepositoryBase<Item>
    {
    }

    //ItemEntrada
    public interface IItemEntradaRepository : IRepositoryBase<ItemEntrada>
    {
    }

    //ItemSaida
    public interface IItemSaidaRepository : IRepositoryBase<ItemSaida>
    {
    }

    //ItemSaidaViewModel
    public interface IItemSaidaViewModelRepository : IRepositoryBase<ItemSaidaViewModel>
    {
    }

    //UnidadeMedidaViewModel
    public interface IUnidadeMedidaViewModelRepository : IRepositoryBase<UnidadeMedidaViewModel>
    {
    }
}
