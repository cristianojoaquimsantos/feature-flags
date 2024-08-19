using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using UnimedFESP.Domain.Core.Mediator;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation
{
    public class UsuarioSistemaFeatureFlagAppService : AppServiceBase<UsuarioSistemaFeatureFlag>, IUsuarioSistemaFeatureFlagAppService
    {
        protected readonly IMapper _mapper;
        protected readonly IUsuarioSistemaFeatureFlagRepository _repository;
        private readonly IMediatorHandler _mediator;

        public UsuarioSistemaFeatureFlagAppService(IUsuarioSistemaFeatureFlagRepository repository,
                                                   IMapper mapper,
                                                   IMediatorHandler mediator)
            : base(repository)
        {
            _repository = repository;
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}
