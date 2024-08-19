using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class IntencaoFuncionalidadeFeatureFlag : Entity, IAggregateRoot
    {
        public IntencaoFuncionalidadeFeatureFlag(Guid intencaoFuncionalidadeId,
                                                 Guid featureFlagId,
                                                 Guid sistemaId)
        {
            IntencaoFuncionalidadeId = intencaoFuncionalidadeId;
            FeatureFlagId = featureFlagId;
            SistemaId = sistemaId;
        }

        public Guid IntencaoFuncionalidadeId { get; private set; }
        public Guid FeatureFlagId { get; private set; }
        public Guid SistemaId { get; private set; }
        
        public virtual FeatureFlag FeatureFlag { get; set; }
        public virtual IntencaoFuncionalidade IntencaoFuncionalidade { get; set; }
    }
}