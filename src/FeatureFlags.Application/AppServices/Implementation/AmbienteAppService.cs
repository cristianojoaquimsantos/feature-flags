using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Application.ViewModel;
using FluentValidation.Results;
using FeatureFlags.Domain.Core.Mediator;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation;

public class AmbienteAppService : AppServiceBase<Ambiente>, IAmbienteAppService
{
    protected readonly IMapper _mapper;
    protected readonly IAmbienteRepository _repository;
    private readonly IMediatorHandler _mediator;

    public AmbienteAppService(IAmbienteRepository repository,
                              IMapper mapper,
                              IMediatorHandler mediator)
        : base(repository)
    {
        _repository = repository;
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<ValidationResult> AtualizarAmbiente(AmbienteViewModel ambiente)
    {
        throw new NotImplementedException();
    }

    public async Task<List<SistemaViewModel>> GetAllAmbiente()
    {
        throw new NotImplementedException();
    }

    public async Task<SistemaViewModel> GetAmbienteById(Guid ambienteId)
    {
        throw new NotImplementedException();
    }

    public async Task<ValidationResult> IncluirAmbiente(AmbienteViewModel ambiente)
    {
        throw new NotImplementedException();
    }

    public async Task<ValidationResult> RemoverAmbiente(Guid ambienteId)
    {
        throw new NotImplementedException();
    }
}