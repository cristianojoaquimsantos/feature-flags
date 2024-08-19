using FeatureFlags.Application.ViewModel;
using FluentValidation.Results;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Application.AppServices.Interface
{
    public interface IFeatureFlagAppService: IAppServiceBase<FeatureFlag>
    {
        Task<ValidationResult> IncluirFeatureFlag(FeatureFlagViewModel featureFlag);
        Task<List<FeatureFlagViewModel>> GetAllFeatureFlag();
        Task<FeatureFlagViewModel> GetFeatureFlagById(Guid? featureFlagId, Guid? sistemaId);
        Task<ValidationResult> RemoverFeatureFlag(Guid featureFlagId, Guid sistemId);
        Task<ValidationResult> AtualizarFeatureFlag(FeatureFlagViewModel featureFlag);
    }
}
