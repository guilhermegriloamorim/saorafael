using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Data;
using AlmoxarifadoRepositories.Dominio;
namespace AlmoxarifadoRepositories.Interfaces
{

    //RepositoryBarraca
    public class RepositoryBarraca : RepositoryBase<Barraca, AlmoxarifadoDbContext>, IBarracaRepository
    {
        public RepositoryBarraca(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }

    //RepositoryItem
    public class RepositoryItem : RepositoryBase<Item, AlmoxarifadoDbContext>, IItemRepository
    {
        public RepositoryItem(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }

    //RepositoryItemEntrada
    public class RepositoryItemEntrada : RepositoryBase<ItemEntrada, AlmoxarifadoDbContext>, IItemEntradaRepository
    {
        public RepositoryItemEntrada(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }

    //RepositoryItemSaida
    public class RepositoryItemSaida : RepositoryBase<ItemSaida, AlmoxarifadoDbContext>, IItemSaidaRepository
    {
        public RepositoryItemSaida(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }

    //RepositoryItemSaidaViewModel
    public class RepositoryItemSaidaViewModel : RepositoryBase<ItemSaidaViewModel, AlmoxarifadoDbContext>, IItemSaidaViewModelRepository
    {
        public RepositoryItemSaidaViewModel(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }

    //RepositoryUnidadeMedidaViewModel
    public class RepositoryUnidadeMedidaViewModel : RepositoryBase<UnidadeMedidaViewModel, AlmoxarifadoDbContext>, IUnidadeMedidaViewModelRepository
    {
        public RepositoryUnidadeMedidaViewModel(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }

}
