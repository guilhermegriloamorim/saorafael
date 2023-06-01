using AlmoxarifadoRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace AlmoxarifadoRepositories.Dominio
{
    public abstract class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity> where TEntity : class where TContext : DbContext
    {
        private readonly TContext _dbContex;

        public RepositoryBase(TContext dbContex)
        {
            _dbContex = dbContex;
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            TEntity entity = await _dbContex.Set<TEntity>().FindAsync(id);
            return entity == null ? null : entity;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            IEnumerable<TEntity> entities = await _dbContex.Set<TEntity>().ToListAsync();
            return entities;
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null) return default;

            await _dbContex.AddAsync(entity);
            await _dbContex.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null) return default;
            _dbContex.Update(entity);
            await _dbContex.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            TEntity entity = await _dbContex.Set<TEntity>().FindAsync(id);
            if (entity == null) return false;
            _dbContex.Remove(entity);
            await _dbContex.SaveChangesAsync();
            return true;
        }
    }
}
