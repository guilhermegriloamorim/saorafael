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
    public interface IRepositoryBarrca : IRepositoryBase<Barraca>
    {
    }
    //Item
    public interface IRepositoryItem : IRepositoryBase<Item>
    {
    }
    //ItemEntrada
    public interface IRepositoryItemEntrada : IRepositoryBase<ItemEntrada>
    {
    }
    //ItemSaida
    public interface IRepositoryItemSaida : IRepositoryBase<ItemSaida>
    {
    }
    //ItemSaidaViewModel
    public interface IRepositoryItemSaidaViewModel : IRepositoryBase<ItemSaidaViewModel>
    {
    }
    //UnidadeMedidaViewModel
    public interface IRepositoryUnidadeMedidaViewModel : IRepositoryBase<UnidadeMedidaViewModel>
    {
    }

}
