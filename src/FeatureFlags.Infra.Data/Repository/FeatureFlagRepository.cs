using FeatureFlags.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Enums;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class FeatureFlagRepository : RepositoryBase<FeatureFlag>, IFeatureFlagRepository
    {
        private readonly FeatureFlagContext _context;

        public FeatureFlagRepository(FeatureFlagContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<FeatureFlag>> ListaFeaturesPorSistema(Guid sistemaId)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeatureFlag>> ListarFeatureFlagPorAmbienteSistema(Guid ambienteId, Guid sistemaId)
        {
            throw new NotImplementedException();
        }

        public Task<FeatureFlag> ObterStatusFeatureFlag(StatusFeatureFlag statusFeatureFlag)
        {
            throw new NotImplementedException();
        }

        public Task PromoverFeatureFlagAmbiente(Guid featureFlagId)
        {
            throw new NotImplementedException();
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
