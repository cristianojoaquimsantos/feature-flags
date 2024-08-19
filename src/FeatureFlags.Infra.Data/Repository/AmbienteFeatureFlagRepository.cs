using FeatureFlags.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class AmbienteFeatureFlagRepository : RepositoryBase<AmbienteFeatureFlag>, IAmbienteFeatureFlagRepository
    {
        protected readonly FeatureFlagContext _context;

        public AmbienteFeatureFlagRepository(FeatureFlagContext context) : base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
