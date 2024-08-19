using FeatureFlags.Domain.Core.Data;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Domain.Repository.Interface
{
    public interface IAmbienteFeatureFlagRepository: IRepository<AmbienteFeatureFlag>, IRepositoryBase<AmbienteFeatureFlag>
    {
    }
}
