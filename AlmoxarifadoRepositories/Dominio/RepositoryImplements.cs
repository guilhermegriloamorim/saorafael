using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Data;
using AlmoxarifadoRepositories.Dominio;
namespace AlmoxarifadoRepositories.Interfaces
{
    public class RepositoryBarraca : RepositoryBase<Barraca, AlmoxarifadoDbContext>, IRepositoryBarrca
    {
        public RepositoryBarraca(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    public class RepositoryItem : RepositoryBase<Item, AlmoxarifadoDbContext>, IRepositoryItem
    {
        public RepositoryItem(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    public class RepositoryItemEntrada : RepositoryBase<ItemEntrada, AlmoxarifadoDbContext>, IRepositoryItemEntrada
    {
        public RepositoryItemEntrada(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    public class RepositoryItemSaida : RepositoryBase<ItemSaida, AlmoxarifadoDbContext>, IRepositoryItemSaida
    {
        public RepositoryItemSaida(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    public class RepositoryItemSaidaViewModel : RepositoryBase<ItemSaidaViewModel, AlmoxarifadoDbContext>, IRepositoryItemSaidaViewModel
    {
        public RepositoryItemSaidaViewModel(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    public class RepositoryUnidadeMedidaViewModel : RepositoryBase<UnidadeMedidaViewModel, AlmoxarifadoDbContext>, IRepositoryUnidadeMedidaViewModel
    {
        public RepositoryUnidadeMedidaViewModel(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
}
