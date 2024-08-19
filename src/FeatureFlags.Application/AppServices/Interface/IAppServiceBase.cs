using UnimedFESP.Domain.Core.Domain;

namespace FeatureFlags.Application.AppServices.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(Guid id);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> FindAll();
    }
}
