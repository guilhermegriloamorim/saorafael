using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Interfaces;
using AlmoxarifadoService.Interfaces;
using AutoMapper;

namespace AlmoxarifadoService.Dominio
{
    //Barrca
    public class ServiceBarraca : ServiceBase<IRepositoryBarrca, Barraca>, IServiceBarraca
    {
        public ServiceBarraca(IRepositoryBarrca repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
    //Item
    public class ServiceItem : ServiceBase<IRepositoryItem, Item>, IServiceItem
    {
        public ServiceItem(IRepositoryItem repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
    //ItemEntrada
    public class ServiceItemEntrada : ServiceBase<IRepositoryItemEntrada, ItemEntrada>, IServiceItemEntrada
    {
        public ServiceItemEntrada(IRepositoryItemEntrada repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
    //ItemSaida
    public class ServiceItemSaida : ServiceBase<IRepositoryItemSaida, ItemSaida>, IServiceItemSaida
    {
        public ServiceItemSaida(IRepositoryItemSaida repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
    //ItemSaidaViewModel
    public class ServiceItemSaidaViewModel : ServiceBase<IRepositoryItemSaidaViewModel, ItemSaidaViewModel>, IServiceItemSaidaViewModel
    {
        public ServiceItemSaidaViewModel(IRepositoryItemSaidaViewModel repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<IList<ItemSaidaViewModel>> GetFillterAsync(string? barraca, string? data)
        {
            return await _repository.GetFillterAsync(barraca, data);
        }
    }
    //UnidadeMedidaViewModel
    public class ServiceUnidadeMedidaViewModel : ServiceBase<IRepositoryUnidadeMedidaViewModel, UnidadeMedidaViewModel>, IServiceUnidadeMedidaViewModel
    {
        public ServiceUnidadeMedidaViewModel(IRepositoryUnidadeMedidaViewModel repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
