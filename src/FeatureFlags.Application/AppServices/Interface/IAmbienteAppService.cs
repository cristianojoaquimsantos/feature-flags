using FeatureFlags.Application.ViewModel;
using FluentValidation.Results;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Application.AppServices.Interface
{
    public interface IAmbienteAppService: IAppServiceBase<Ambiente>
    {
        Task<ValidationResult> IncluirAmbiente(AmbienteViewModel ambiente);
        Task<List<SistemaViewModel>> GetAllAmbiente();
        Task<SistemaViewModel> GetAmbienteById(Guid ambienteId);
        Task<ValidationResult> RemoverAmbiente(Guid ambienteId);
        Task<ValidationResult> AtualizarAmbiente(AmbienteViewModel ambiente);
    }
}
