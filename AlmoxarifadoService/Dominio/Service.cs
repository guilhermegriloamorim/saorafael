using Almoxarifado.Dominio.Model;
using AlmoxarifadoRepositories.Interfaces;
using AlmoxarifadoService.Interfaces;
using AutoMapper;
namespace AlmoxarifadoService.Dominio
{
    //ServiceBarraca
    public class ServiceBarraca : ServiceBase<IBarracaRepository, Barraca>, IBarracaService
    {
        public ServiceBarraca(IBarracaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    //ServiceItem
    public class ServiceItem : ServiceBase<IItemRepository, Item>, IItemService
    {
        public ServiceItem(IItemRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    //ServiceItemEntrada
    public class ServiceItemEntrada : ServiceBase<IItemEntradaRepository, ItemEntrada>, IItemEntradaService
    {
        public ServiceItemEntrada(IItemEntradaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    //ServiceItemSaida
    public class ServiceItemSaida : ServiceBase<IItemSaidaRepository, ItemSaida>, IItemSaidaService
    {
        public ServiceItemSaida(IItemSaidaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    //ItemSaidaViewModel
    public class ItemSaidaViewModel : ServiceBase<IItemSaidaRepository, ItemSaida>, IItemSaidaViewModel
    {
        public ItemSaidaViewModel(IItemSaidaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }

    //ItemEntradaViewModel
    public class ItemEntradaViewModel : ServiceBase<IItemEntradaRepository, ItemEntrada>, IItemEntradaViewModel
    {
        public ItemEntradaViewModel(IItemEntradaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
