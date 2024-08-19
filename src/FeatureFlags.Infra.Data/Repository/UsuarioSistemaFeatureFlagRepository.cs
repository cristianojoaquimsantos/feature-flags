using FeatureFlags.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class UsuarioSistemaFeatureFlagRepository : RepositoryBase<UsuarioSistemaFeatureFlag>, IUsuarioSistemaFeatureFlagRepository
    {
        private readonly FeatureFlagContext _context;

        public UsuarioSistemaFeatureFlagRepository(FeatureFlagContext context) : base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
