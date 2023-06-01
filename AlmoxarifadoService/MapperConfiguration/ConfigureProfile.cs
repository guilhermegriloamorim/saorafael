using Almoxarifado.Dominio.Model;
using AlmoxarifadoService.Dominio.DTO;
using AutoMapper;
namespace AlmoxarifadoService.MapperConfiguration
{
    public class ConfigureProfile : Profile
    {
        public ConfigureProfile()
        {
            CreateMap<Barraca, BarracaCreateDto>().ReverseMap();
            CreateMap<Barraca, BarracaUpdateDto>().ReverseMap();
            CreateMap<Barraca, BarracaReadDto>().ReverseMap();

            CreateMap<Item, ItemCreateDto>().ReverseMap();
            CreateMap<Item, ItemUpdateDto>().ReverseMap();
            CreateMap<Item, ItemReadDto>().ReverseMap();

            CreateMap<ItemSaida, ItemSaidaCreateDto>().ReverseMap();
            CreateMap<ItemSaida, ItemSaidaUpdateDto>().ReverseMap();
            CreateMap<ItemSaida, ItemSaidaReadDto>().ReverseMap();

            CreateMap<ItemEntrada, ItemEntradaCreateDto>().ReverseMap();
            CreateMap<ItemEntrada, ItemEntradaUpdateDto>().ReverseMap();
            CreateMap<ItemEntrada, ItemEntradaReadDto>().ReverseMap();
        }
    }
}
