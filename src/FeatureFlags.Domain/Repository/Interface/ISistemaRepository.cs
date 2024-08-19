using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Core.Data;

namespace FeatureFlags.Domain.Repository.Interface
{
    public interface ISistemaRepository: IRepository<Sistema>, IRepositoryBase<Sistema>
    {
    }
}
