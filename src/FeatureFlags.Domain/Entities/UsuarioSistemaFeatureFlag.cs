using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    public class UsuarioSistemaFeatureFlag: Entity, IAggregateRoot
    {
        public UsuarioSistemaFeatureFlag(Guid usuarioId,
                                         Guid sistemaId,
                                         Guid featureFlagId)
        {
            UsuarioId = usuarioId;
            SistemaId = sistemaId;
            FeatureFlagId = featureFlagId;
        }

        public Guid UsuarioId { get; private set; }
        public Guid SistemaId { get; private set; }
        public Guid FeatureFlagId { get; private set; }
        public virtual UsuarioSistema UsuarioSistema { get; set; }
        public virtual FeatureFlag FeatureFlag { get; private set; }
    }
}
