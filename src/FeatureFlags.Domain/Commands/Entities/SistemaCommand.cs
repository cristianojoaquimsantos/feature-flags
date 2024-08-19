using FeatureFlags.Domain.Core.Message;

namespace FeatureFlags.Domain.Commands.Entities
{
    public abstract class SistemaCommand: Command
    {
        public Guid SistemaId { get; protected set; }
        public string NomeSistema { get; protected set; }
        public string DescritivoSistema { get; protected set; }
        public bool OperacaoAtiva { get; protected set; }
    }
}
