using FeatureFlags.Domain.Commands.Entities;

namespace FeatureFlags.Domain.Commands.Data
{
    public class RemoveSistemaCommand : SistemaCommand
    {
        public RemoveSistemaCommand(Guid sistemaId)
        {

        }

        public Guid SistemaId { get; set; }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
