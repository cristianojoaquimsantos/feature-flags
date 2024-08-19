using FeatureFlags.Application.ViewModel;
using FluentValidation.Results;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Application.AppServices.Interface
{
    public interface ISistemaAppService: IAppServiceBase<Sistema>
    {
        Task<ValidationResult> IncluirSistema(SistemaViewModel sistema);
        Task<List<SistemaViewModel>> GetAllSistema();
        Task<SistemaViewModel> GetSistemaById(Guid sistemaId);
        Task<ValidationResult> RemoverSistema(Guid sistemaId);
        Task<ValidationResult> AtualizarSistema(SistemaViewModel sistema);
    }
}
