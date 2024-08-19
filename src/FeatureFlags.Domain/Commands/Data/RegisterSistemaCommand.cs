using FeatureFlags.Domain.Commands.Entities;
using FeatureFlags.Domain.Commands.Validations;

namespace FeatureFlags.Domain.Commands.Data
{
    public class RegisterSistemaCommand : SistemaCommand
    {
        public RegisterSistemaCommand(Guid sistemaId,
                       string nomeSistema,
                       string descritivoSistema,
                       bool operacaoAtiva)
        {
            SistemaId = sistemaId;
            NomeSistema = nomeSistema;
            DescritivoSistema = descritivoSistema;
            OperacaoAtiva = operacaoAtiva;
        }

        public override bool IsValid()
        {
            ValidationResult = new SistemaCommandValidation().Validate(this);
            return base.IsValid();
        }
    }
}
