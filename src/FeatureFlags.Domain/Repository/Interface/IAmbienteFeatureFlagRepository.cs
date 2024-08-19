using FeatureFlags.Domain.Entities;
using UnimedFESP.Domain.Core.Data;

namespace FeatureFlags.Domain.Repository.Interface
{
    public interface IAmbienteFeatureFlagRepository: IRepository<AmbienteFeatureFlag>, IRepositoryBase<AmbienteFeatureFlag>
    {
    }
}
