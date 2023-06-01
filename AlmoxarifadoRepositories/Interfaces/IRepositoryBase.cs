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

    public interface IRepositoryBarrca : IRepositoryBase<Barraca>
    {
    }
    public interface IRepositoryItem : IRepositoryBase<Item>
    {
    }
    public interface IRepositoryItemEntrada : IRepositoryBase<ItemEntrada>
    {
    }
    public interface IRepositoryItemSaida : IRepositoryBase<ItemSaida>
    {
    }
    public interface IRepositoryItemSaidaViewModel : IRepositoryBase<ItemSaidaViewModel>
    {
    }
    public interface IRepositoryUnidadeMedidaViewModel : IRepositoryBase<UnidadeMedidaViewModel>
    {
    }
}
