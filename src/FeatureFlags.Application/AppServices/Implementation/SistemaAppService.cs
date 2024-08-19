using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Application.ViewModel;
using FluentValidation.Results;
using FeatureFlags.Domain.Core.Mediator;
using FeatureFlags.Domain.Commands.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation
{
    public class SistemaAppService: AppServiceBase<Sistema>, ISistemaAppService
    {
        protected readonly IMapper _mapper;
        protected readonly ISistemaRepository _sistemaRepository;
        private readonly IMediatorHandler _mediator;

        public SistemaAppService(ISistemaRepository sistemaRepository,
                                 IMapper mapper,
                                 IMediatorHandler mediator)
            :base(sistemaRepository)
        {
            _sistemaRepository = sistemaRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<ValidationResult> AtualizarSistema(SistemaViewModel sistema)
        {
            var _sistemaCommand = _mapper.Map<RegisterSistemaCommand> (sistema);
            return await _mediator.SendCommand(_sistemaCommand);
        }

        public async Task<List<SistemaViewModel>> GetAllSistema()
        {
            return _mapper.Map<List<SistemaViewModel>>(await _repository.GetAll());
        }

        public async Task<SistemaViewModel> GetSistemaById(Guid sistemaId)
        {
            return _mapper.Map<SistemaViewModel>(await _repository.GetById(sistemaId));
        }

        public async Task<ValidationResult> IncluirSistema(SistemaViewModel sistema)
        {
            var _sistemaCommand = _mapper.Map<RegisterSistemaCommand>(sistema);
            return await _mediator.SendCommand(_sistemaCommand);
        }

        public async Task<ValidationResult> RemoverSistema(Guid sistemaId)
        {
            var _sistemaCommand = new RemoveSistemaCommand(sistemaId);
            return await _mediator.SendCommand(_sistemaCommand);
        }
    }
}
