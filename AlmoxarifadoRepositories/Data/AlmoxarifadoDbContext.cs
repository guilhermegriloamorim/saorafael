using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
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


            //varchar(255) por default
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                               .SelectMany(e => e.GetProperties()
                                              .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(255)");
            }

            //aplicando as configurações das entidades
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlmoxarifadoDbContext).Assembly);


            //delete em cascata
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            base.OnModelCreating(modelBuilder);
        }

    }
}
