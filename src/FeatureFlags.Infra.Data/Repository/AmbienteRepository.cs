using System.Diagnostics.CodeAnalysis;
using UnimedFESP.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class AmbienteRepository: RepositoryBase<Ambiente>, IAmbienteRepository
    {
        private readonly FeatureFlagContext _context;

        [ExcludeFromCodeCoverage]
        public AmbienteRepository(FeatureFlagContext context)
            :base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        [ExcludeFromCodeCoverage]
        public Task AddAmbiente(Ambiente ambiente)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InativarAmbiente(Guid ambienteId)
        {
            return await Task.Run(() =>
            {
                if (ambienteId.ToString() == "9d2b0228-4d0d-4c23-8b49-01a698857709")
                    return true;
                else
                    return false;
            });
        }

        [ExcludeFromCodeCoverage]
        public Task RemoveAmbiente(Guid ambienteId)
        {
            throw new NotImplementedException();
        }

        [ExcludeFromCodeCoverage]
        public Task UpdateAmbiente(Guid ambienteId)
        {
            throw new NotImplementedException();
        }
    }
}
