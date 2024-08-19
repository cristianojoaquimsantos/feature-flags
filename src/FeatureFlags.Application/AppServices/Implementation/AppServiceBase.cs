using FeatureFlags.Application.AppServices.Interface;
using UnimedFESP.Domain.Core.Domain;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation
{
    public class AppServiceBase<TEntity>: IAppServiceBase<TEntity> where TEntity: Entity
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        protected AppServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual async Task<List<TEntity>> FindAll()
        {
            return await _repository.GetAll();
        }

        public Task<TEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
