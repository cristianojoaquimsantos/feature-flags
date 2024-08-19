using System.Diagnostics.CodeAnalysis;

namespace FeatureFlags.Application.ViewModel
{
    [ExcludeFromCodeCoverage]
    public class AmbienteFeatureFlagViewModel
    {
        public AmbienteFeatureFlagViewModel(Guid ambienteId,
                                          Guid featureFlagId,
                                          Guid sistemaId,
                                          Guid usuarioId)
        {
            AmbienteId = ambienteId;
            FeatureFlagId = featureFlagId;
            SistemaId = sistemaId;
            UsuarioId = usuarioId;
        }

        public Guid AmbienteId { get; set; }
        public Guid FeatureFlagId { get; set; }
        public Guid SistemaId { get; set; }
        public Guid UsuarioId { get; set; }

        public virtual AmbienteViewModel Ambiente { get; set; }
        public virtual FeatureFlagViewModel FeatureFlag { get; set; }
    }
}