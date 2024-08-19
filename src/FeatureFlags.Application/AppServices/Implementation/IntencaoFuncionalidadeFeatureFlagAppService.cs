using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using UnimedFESP.Domain.Core.Mediator;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation;

public class IntencaoFuncionalidadeFeatureFlagAppService: AppServiceBase<IntencaoFuncionalidadeFeatureFlag>, IIntencaoFuncionalidadeFeatureFlagAppService
{
    protected readonly IMapper _mapper;
    protected readonly IIntencaoFuncionalidadeFeatureFlagRepository _repository;
    private readonly IMediatorHandler _mediator;

    public IntencaoFuncionalidadeFeatureFlagAppService(IIntencaoFuncionalidadeFeatureFlagRepository repository,
                                                       IMapper mapper,
                                                       IMediatorHandler mediator)
    :base(repository)
    {
        _repository = repository;
        _mapper = mapper;
        _mediator = mediator;
    }
}