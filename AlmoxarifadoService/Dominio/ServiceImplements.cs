using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Interfaces;
using AlmoxarifadoService.Interfaces;
using AutoMapper;
namespace AlmoxarifadoService.Dominio
{

    public class ServiceBarraca : ServiceBase<IRepositoryBarrca, Barraca>, IServiceBarraca
    {
        public ServiceBarraca(IRepositoryBarrca repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    public class ServiceItem : ServiceBase<IRepositoryItem, Item>, IServiceItem
    {
        public ServiceItem(IRepositoryItem repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    public class ServiceItemEntrada : ServiceBase<IRepositoryItemEntrada, ItemEntrada>, IServiceItemEntrada
    {
        public ServiceItemEntrada(IRepositoryItemEntrada repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    public class ServiceItemSaida : ServiceBase<IRepositoryItemSaida, ItemSaida>, IServiceItemSaida
    {
        public ServiceItemSaida(IRepositoryItemSaida repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    public class ServiceItemSaidaViewModel : ServiceBase<IRepositoryItemSaida, ItemSaida>, IServiceItemSaidaViewModel
    {
        public ServiceItemSaidaViewModel(IRepositoryItemSaida repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    public class ServiceItemEntradaViewModel : ServiceBase<IRepositoryItemEntrada, ItemEntrada>, IServiceItemEntradaViewModel
    {
        public ServiceItemEntradaViewModel(IRepositoryItemEntrada repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    public class ServiceUnidadeMedidaViewModel : ServiceBase<IRepositoryUnidadeMedidaViewModel, UnidadeMedidaViewModel>, IServiceUnidadeMedidaViewModel
    {
        public ServiceUnidadeMedidaViewModel(IRepositoryUnidadeMedidaViewModel repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }


}
