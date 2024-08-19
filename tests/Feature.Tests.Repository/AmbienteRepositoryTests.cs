using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;
using FeatureFlags.Infra.Data.Repository;

namespace Feature.Tests.Repository
{
    public class AmbienteRepositoryTests
    {
        AmbienteRepository _ambienteRepository;
        protected readonly IAmbienteRepository _ambienteRepositoryMock;
        private readonly FeatureFlagContext _context;

        [Fact(DisplayName = "Inativar ambiente existente")]
        [Trait("Ambiente", "Boolean")]
        public void InativarAmbienteExistente()
        {
            _ambienteRepository = new AmbienteRepository(_context);

            Guid ambienteId = new Guid("9d2b0228-4d0d-4c23-8b49-01a698857709");
            Assert.True(_ambienteRepository.InativarAmbiente(ambienteId).Result);
        }

        [Fact(DisplayName = "Inativar ambiente N�O existente")]
        [Trait("Ambiente", "Boolean")]
        public void InativarAmbienteNaoExistente()
        {
            _ambienteRepository = new AmbienteRepository(_context);

            Guid ambienteId = Guid.NewGuid();
            var ret = _ambienteRepository.InativarAmbiente(ambienteId).Result;
            Assert.False(_ambienteRepository.InativarAmbiente(ambienteId).Result);
        }

        [Fact(Skip = "Teste de exce��o ao inativar ambiente ainda n�o implementado")]
        public void TestaExceptionAoInativaAmbiente() 
        { 
        }
    }
}