using System.Diagnostics.CodeAnalysis;

namespace FeatureFlags.Application.ViewModel
{
    [ExcludeFromCodeCoverage]
    public class AmbienteViewModel
    {
        protected AmbienteViewModel()
        {
        }

        public AmbienteViewModel(Guid ambienteId,
            string nomeAmbiente,
            string descricaoAmbiente,
            bool ambienteAtivo)
        {
            AmbienteId = ambienteId;
            NomeAmbiente = nomeAmbiente;
            DescricaoAmbiente = descricaoAmbiente;
            AmbienteAtivo = ambienteAtivo;
        }

        public Guid AmbienteId { get; set; }
        public string NomeAmbiente { get; set; }
        public string DescricaoAmbiente { get; set; }
        public bool AmbienteAtivo { get; set; }

        public virtual IList<AmbienteFeatureFlagViewModel> AmbienteFeatureFlag { get; set; }
    }
}