using AutoMapper;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Application.ViewModel;
using FluentValidation.Results;
using UnimedFESP.Domain.Core.Mediator;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;

namespace FeatureFlags.Application.AppServices.Implementation
{
    public class FeatureFlagAppService : AppServiceBase<FeatureFlag>, IFeatureFlagAppService
    {
        protected readonly IMapper _mapper;
        protected readonly IFeatureFlagRepository _repository;
        private readonly IMediatorHandler _mediator;

        public FeatureFlagAppService(IFeatureFlagRepository repository,
                                     IMapper mapper,
                                     IMediatorHandler mediator)
        : base(repository)
        {
            _mapper = mapper;
            _repository = repository;
            _mediator = mediator;
        }

        public Task<ValidationResult> AtualizarFeatureFlag(FeatureFlagViewModel featureFlag)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeatureFlagViewModel>> GetAllFeatureFlag()
        {
            throw new NotImplementedException();
        }

        public Task<FeatureFlagViewModel> GetFeatureFlagById(Guid? featureFlagId, Guid? sistemaId)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> IncluirFeatureFlag(FeatureFlagViewModel featureFlag)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> RemoverFeatureFlag(Guid featureFlagId, Guid sistemId)
        {
            throw new NotImplementedException();
        }
    }
}