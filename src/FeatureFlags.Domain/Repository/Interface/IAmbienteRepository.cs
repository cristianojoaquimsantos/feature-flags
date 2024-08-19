using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Core.Data;

namespace FeatureFlags.Domain.Repository.Interface
{
    public interface IAmbienteRepository: IRepositoryBase<Ambiente>, IRepository<Ambiente>
    {
        Task<bool> InativarAmbiente(Guid ambienteId);
        Task AddAmbiente(Ambiente ambiente);
        Task UpdateAmbiente(Guid ambienteId);
        Task RemoveAmbiente(Guid ambienteId);
    }
}