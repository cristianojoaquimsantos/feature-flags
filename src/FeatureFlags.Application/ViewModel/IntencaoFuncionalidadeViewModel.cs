using System.Diagnostics.CodeAnalysis;

namespace FeatureFlags.Application.ViewModel
{
    [ExcludeFromCodeCoverage]
    public class IntencaoFuncionalidadeViewModel
    {
        public IntencaoFuncionalidadeViewModel(Guid intencaoFuncionalidadeId,
                                      Guid sistemaId,
                                      string descricaoIntecaoFuncionalidade)
        {
            IntencaoFuncionalidadeId = intencaoFuncionalidadeId;
            SistemaId = sistemaId;
            DescricaoIntecaoFuncionalidade = descricaoIntecaoFuncionalidade;
        }

        protected IntencaoFuncionalidadeViewModel()
        {

        }

        public Guid IntencaoFuncionalidadeId { get; set; }
        public Guid SistemaId { get; set; }
        public string DescricaoIntecaoFuncionalidade { get; set; }

        public virtual SistemaViewModel Sistema { get; set; }
        public virtual IntencaoFuncionalidadeFeatureFlagViewModel IntencaoFuncionalidadeFeatureFlag { get; set; }
    }
}