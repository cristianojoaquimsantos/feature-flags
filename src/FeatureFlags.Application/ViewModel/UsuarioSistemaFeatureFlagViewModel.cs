namespace FeatureFlags.Application.ViewModel
{
    public class UsuarioSistemaFeatureFlagViewModel
    {
        public UsuarioSistemaFeatureFlagViewModel(Guid usuarioId,
                                         Guid sistemaId,
                                         Guid featureFlagId)
        {
            UsuarioId = usuarioId;
            SistemaId = sistemaId;
            FeatureFlagId = featureFlagId;
        }

        public Guid UsuarioId { get; set; }
        public Guid SistemaId { get; set; }
        public Guid FeatureFlagId { get; set; }

        public virtual UsuarioSistemaViewModel UsuarioSistema { get; set; }
        public virtual FeatureFlagViewModel FeatureFlag { get; private set; }
    }
}
