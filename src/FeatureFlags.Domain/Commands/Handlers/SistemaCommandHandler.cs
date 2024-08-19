using FeatureFlags.Domain.Commands.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FluentValidation.Results;
using MediatR;
using UnimedFESP.Domain.Core.Messaging;

namespace FeatureFlags.Domain.Commands.Handlers
{
    public class SistemaCommandHandler : CommandHandler,
        IRequestHandler<RegisterSistemaCommand, ValidationResult>
    {
        private readonly ISistemaRepository _sistemaRepository;

        public SistemaCommandHandler(ISistemaRepository sistemaRepository)
        {
            _sistemaRepository = sistemaRepository;    
        }

        public async Task<ValidationResult> Handle(RegisterSistemaCommand request, CancellationToken cancellationToken)
        {
            var sistema = new Sistema(Guid.NewGuid(), 
                                      request.NomeSistema,
                                      request.DescritivoSistema,
                                      request.OperacaoAtiva);

            _sistemaRepository.Add(sistema);
            return await Commit(_sistemaRepository.UnitOfWork);
        }
    }
}
