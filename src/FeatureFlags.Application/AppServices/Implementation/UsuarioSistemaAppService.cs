using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Domain.Core.Mediator;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation
{
    public class UsuarioSistemaAppService: AppServiceBase<UsuarioSistema>, IUsuarioSistemaAppService
    {
        protected readonly IMapper _mapper;
        protected readonly IUsuarioSistemaRepository _repository;
        private readonly IMediatorHandler _mediator;

        public UsuarioSistemaAppService(IUsuarioSistemaRepository repository,
                                        IMapper mapper,
                                        IMediatorHandler mediator)
            :base(repository)
        {
            _repository = repository;
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}
