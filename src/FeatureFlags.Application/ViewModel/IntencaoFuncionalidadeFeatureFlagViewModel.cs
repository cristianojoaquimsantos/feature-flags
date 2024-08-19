using System.Diagnostics.CodeAnalysis;

namespace FeatureFlags.Application.ViewModel
{
    [ExcludeFromCodeCoverage]
    public class IntencaoFuncionalidadeFeatureFlagViewModel
    {
        public IntencaoFuncionalidadeFeatureFlagViewModel(Guid intencaoFuncionalidadeId,
                                                 Guid featureFlagId,
                                                 Guid sistemaId)
        {
            IntencaoFuncionalidadeId = intencaoFuncionalidadeId;
            FeatureFlagId = featureFlagId;
            SistemaId = sistemaId;
        }

        public Guid IntencaoFuncionalidadeId { get; set; }
        public Guid FeatureFlagId { get; set; }
        public Guid SistemaId { get; set; }

        public virtual FeatureFlagViewModel FeatureFlag { get; set; }
        public virtual IntencaoFuncionalidadeViewModel IntencaoFuncionalidade { get; set; }
    }
}