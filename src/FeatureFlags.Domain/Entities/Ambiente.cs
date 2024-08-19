using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Ambiente: Entity, IAggregateRoot
    {
        protected Ambiente()
        {
        }

        public Ambiente(Guid ambienteId,
            string nomeAmbiente,
            string descricaoAmbiente,
            bool ambienteAtivo)
        {
            AmbienteId = ambienteId;
            NomeAmbiente = nomeAmbiente;
            DescricaoAmbiente = descricaoAmbiente;
            AmbienteAtivo = ambienteAtivo;
        }

        public Guid AmbienteId { get; private set; }
        public string NomeAmbiente { get; private set; }
        public string DescricaoAmbiente { get; private set; }
        public bool AmbienteAtivo { get; set; }
        
        public virtual IList<AmbienteFeatureFlag> AmbienteFeatureFlag { get; set; }
    }
}