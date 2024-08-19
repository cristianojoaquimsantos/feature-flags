using System.Diagnostics.CodeAnalysis;
using UnimedFESP.Domain.Core.Domain;

namespace FeatureFlags.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class AmbienteFeatureFlag: Entity, IAggregateRoot
    {
        public AmbienteFeatureFlag(Guid ambienteId,
                                          Guid featureFlagId,
                                          Guid sistemaId,
                                          Guid usuarioId)
        {
            AmbienteId = ambienteId;
            FeatureFlagId = featureFlagId;
            SistemaId = sistemaId;
            UsuarioId = usuarioId;
        }

        public Guid AmbienteId { get; private set; }
        public Guid FeatureFlagId { get; private set; }
        public Guid SistemaId { get; private set; }
        public Guid UsuarioId { get; private set; }

        public virtual Ambiente Ambiente { get; set; }
        public virtual FeatureFlag FeatureFlag { get; set; }
    }
}