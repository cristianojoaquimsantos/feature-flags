using FeatureFlags.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class UsuarioSistemaRepository : RepositoryBase<UsuarioSistema>, IUsuarioSistemaRepository
    {
        private readonly FeatureFlagContext _context;

        public UsuarioSistemaRepository(FeatureFlagContext context) : base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
