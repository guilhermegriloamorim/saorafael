using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoService.Dominio.DTO;
using AutoMapper;
namespace AlmoxarifadoService.MapperConfiguration
{
    public class ConfigureProfile : Profile
    {
        public ConfigureProfile()
        {
            CreateMap<Barraca, BarracaDtoCreate>().ReverseMap();
            CreateMap<Barraca, BarracaDtoUpdate>().ReverseMap();
            CreateMap<Barraca, BarracaDtoRead>().ReverseMap();

            CreateMap<Item, ItemDtoCreate>().ReverseMap();
            CreateMap<Item, ItemDtoUpdate>().ReverseMap();
            CreateMap<Item, ItemDtoRead>().ReverseMap();

            CreateMap<ItemSaida, ItemSaidaDtoCreate>().ReverseMap();
            CreateMap<ItemSaida, ItemSaidaDtoUpdate>().ReverseMap();
            CreateMap<ItemSaida, ItemSaidaDtoRead>().ReverseMap();

            CreateMap<ItemEntrada, ItemEntradaDtoCreate>().ReverseMap();
            CreateMap<ItemEntrada, ItemEntradaDtoUpdate>().ReverseMap();
            CreateMap<ItemEntrada, ItemEntradaDtoRead>().ReverseMap();

            CreateMap<ItemSaidaViewModel, ItemSaidaViewModel>().ReverseMap();
            CreateMap<UnidadeMedidaViewModel, UnidadeMedidaViewModel>().ReverseMap();

        }
    }
}
