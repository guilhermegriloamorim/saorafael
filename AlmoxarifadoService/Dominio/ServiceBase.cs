using AlmoxarifadoRepositories.Interfaces;
using AlmoxarifadoService.Interfaces;
using AutoMapper;
namespace AlmoxarifadoService.Dominio
{

    public abstract class ServiceBase<TRepository, TEntity> : IServiceBase where TRepository : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly IMapper _mapper;
        protected readonly TRepository _repository;

        public ServiceBase(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<TDto> GetByIdAsync<TDto>(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return default;
            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task<IEnumerable<TDto>> GetAllAsync<TDto>()
        {
            var entity = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entity);
        }

        public virtual async Task<TDtoRead> AddAsync<TDtoRead, TDto>(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.AddAsync(entity);
            return _mapper.Map<TDtoRead>(entity);
        }

        public async Task<IList<TDtoRead>> AddRangeAsync<TDtoRead, TDtoCreate>(IList<TDtoCreate> dtos)
        {
            var dtosRead = new List<TDtoRead>();
            foreach (var dto in dtos)
            {
                var entity = _mapper.Map<TEntity>(dto);
                await _repository.AddAsync(entity);
                dtosRead.Add(_mapper.Map<TDtoRead>(entity));
            }
            return dtosRead;
        }

        public virtual async Task<TDto> UpdateAsync<TDto>(Guid id, TDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return default;
            _mapper.Map(dto, entity);
            await _repository.UpdateAsync(entity);
            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return default;
            return await _repository.DeleteAsync(id);
        }
    }
}
