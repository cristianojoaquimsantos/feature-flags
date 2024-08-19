using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Domain.Core.Mediator;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation;

public class IntencaoFuncionalidadeAppService: AppServiceBase<IntencaoFuncionalidade>, IIntencaoFuncionalidadeAppService
{
    protected readonly IMapper _mapper;
    protected readonly IIntencaoFuncionalidadeRepository _repository;
    private readonly IMediatorHandler _mediator;

    public IntencaoFuncionalidadeAppService(IIntencaoFuncionalidadeRepository repository,
                                            IMapper mapper,
                                            IMediatorHandler mediator)
    :base(repository)
    {
        _mapper = mapper;
        _repository = repository;
        _mediator = mediator;
    }
}