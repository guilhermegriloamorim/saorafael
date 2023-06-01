using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Data.Configuration;
using Microsoft.EntityFrameworkCore;
namespace AlmoxarifadoRepositories.Data
{
    public class AlmoxarifadoDbContext : DbContext
    {
        public DbSet<Barraca> Barracas { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<ItemEntrada> ItensEntrada { get; set; }
        public DbSet<ItemSaida> ItensSaida { get; set; }
        public DbSet<ItemSaidaViewModel> ItemSaidaViewModel { get; set; }
        public DbSet<UnidadeMedidaViewModel> UnidadeMedidaViewModel { get; set; }

        public AlmoxarifadoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<ItemSaidaViewModel>(
                    e =>
                    {
                        e.HasNoKey();
                        e.ToView("VIEW_ITENS_SAIDA");
                    });

            modelBuilder
               .Entity<UnidadeMedidaViewModel>(
                   e =>
                   {
                       e.HasNoKey();
                       e.ToTable("UnidadeMedida");
                   });

            modelBuilder.ApplyConfiguration(new BarracaConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new ItemEntradaConfiguration());
            modelBuilder.ApplyConfiguration(new ItemSaidaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
