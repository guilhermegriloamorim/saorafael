using Almoxarifado.Dominio.Model;
using Almoxarifado.Dominio.ViewModel;
using AlmoxarifadoRepositories.Data;
using AlmoxarifadoRepositories.Dominio;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Globalization;

namespace AlmoxarifadoRepositories.Interfaces
{
    //Barrca
    public class RepositoryBarraca : RepositoryBase<Barraca, AlmoxarifadoDbContext>, IRepositoryBarrca
    {
        public RepositoryBarraca(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    //Item
    public class RepositoryItem : RepositoryBase<Item, AlmoxarifadoDbContext>, IRepositoryItem
    {
        public RepositoryItem(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    //ItemEntrada
    public class RepositoryItemEntrada : RepositoryBase<ItemEntrada, AlmoxarifadoDbContext>, IRepositoryItemEntrada
    {
        public RepositoryItemEntrada(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    //ItemSaida
    public class RepositoryItemSaida : RepositoryBase<ItemSaida, AlmoxarifadoDbContext>, IRepositoryItemSaida
    {
        public RepositoryItemSaida(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
    //ItemSaidaViewModel
    public class RepositoryItemSaidaViewModel : RepositoryBase<ItemSaidaViewModel, AlmoxarifadoDbContext>, IRepositoryItemSaidaViewModel
    {
        public RepositoryItemSaidaViewModel(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }

        public async Task<IList<ItemSaidaViewModel>> GetFillterAsync(string barraca, string? data)
        {
            var query = _dbContex.ItemSaidaViewModel.AsQueryable();

            if (barraca != "Todos")
                query = query.Where(x => x.NOME_BARRCA == barraca).AsQueryable();

            if (!string.IsNullOrEmpty(data))
            {
                DateTime dataConvertida = DateTime.ParseExact(data, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                query = query.Where(x => x.DT_SAIDA.Value.Date == dataConvertida.Date.Date).AsQueryable();
            }

            return await query.ToListAsync();
        }
    }
    //UnidadeMedidaViewModel
    public class RepositoryUnidadeMedidaViewModel : RepositoryBase<UnidadeMedidaViewModel, AlmoxarifadoDbContext>, IRepositoryUnidadeMedidaViewModel
    {
        public RepositoryUnidadeMedidaViewModel(AlmoxarifadoDbContext dbContex) : base(dbContex)
        {
        }
    }
}
