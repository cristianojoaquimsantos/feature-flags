using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class IntencaoFuncionalidade: Entity, IAggregateRoot
    {
        public IntencaoFuncionalidade(Guid intencaoFuncionalidadeId,
                                      Guid sistemaId,
                                      string descricaoIntecaoFuncionalidade)
        {
            IntencaoFuncionalidadeId = intencaoFuncionalidadeId;
            SistemaId = sistemaId;
            DescricaoIntecaoFuncionalidade = descricaoIntecaoFuncionalidade;
        }

        protected IntencaoFuncionalidade()
        {
            
        }

        public Guid IntencaoFuncionalidadeId { get; private set; }
        public Guid SistemaId { get; private set; }
        public string DescricaoIntecaoFuncionalidade { get; private set; }
        
        public virtual Sistema Sistema { get; set; }
        public virtual IntencaoFuncionalidadeFeatureFlag IntencaoFuncionalidadeFeatureFlag { get; set; }
    }
}