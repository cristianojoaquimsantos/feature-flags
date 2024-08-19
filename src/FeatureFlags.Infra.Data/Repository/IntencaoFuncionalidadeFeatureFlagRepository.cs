using UnimedFESP.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class IntencaoFuncionalidadeFeatureFlagRepository : RepositoryBase<IntencaoFuncionalidadeFeatureFlag>, IIntencaoFuncionalidadeFeatureFlagRepository
    {
        private readonly FeatureFlagContext _context;

        public IntencaoFuncionalidadeFeatureFlagRepository(FeatureFlagContext context) : base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
