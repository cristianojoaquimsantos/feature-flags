using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Enums;
using UnimedFESP.Domain.Core.Data;

namespace FeatureFlags.Domain.Repository.Interface
{
    public interface IFeatureFlagRepository : IRepository<FeatureFlag>, IRepositoryBase<FeatureFlag>
    {
        Task PromoverFeatureFlagAmbiente(Guid featureFlagId);
        Task<List<FeatureFlag>> ListaFeaturesPorSistema(Guid sistemaId);
        Task<FeatureFlag> ObterStatusFeatureFlag(StatusFeatureFlag statusFeatureFlag);
        Task<List<FeatureFlag>> ListarFeatureFlagPorAmbienteSistema(Guid ambienteId, Guid sistemaId);
    }
}