using Almoxarifado.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AlmoxarifadoRepositories.Data.Configuration
{
    //Barraca
    public class BarracaConfiguration : IEntityTypeConfiguration<Barraca>
    {
        public void Configure(EntityTypeBuilder<Barraca> builder)
        {
            builder.HasIndex(p => p.Nome);
        }
    }

    //Item
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasIndex(p => p.Codigo);
        }
    }

    //ItemEntrada
    public class ItemEntradaConfiguration : IEntityTypeConfiguration<ItemEntrada>
    {
        public void Configure(EntityTypeBuilder<ItemEntrada> builder)
        {
            builder.HasIndex(p => p.ItemId);
        }
    }

    //ItemSaida
    public class ItemSaidaConfiguration : IEntityTypeConfiguration<ItemSaida>
    {
        public void Configure(EntityTypeBuilder<ItemSaida> builder)
        {
            builder.HasIndex(p => p.ItemId);
        }
    }





}
