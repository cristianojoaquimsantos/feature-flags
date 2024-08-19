using System.Diagnostics.CodeAnalysis;

namespace FeatureFlags.Application.ViewModel
{
    [ExcludeFromCodeCoverage]
    public class SistemaViewModel
    {
        public SistemaViewModel(Guid sistemaId,
                       string nomeSistema,
                       string descritivoSistema,
                       bool operacaoAtiva)
        {
            SistemaId = sistemaId;
            NomeSistema = nomeSistema;
            DescritivoSistema = descritivoSistema;
            OperacaoAtiva = operacaoAtiva;
        }

        public Guid SistemaId { get; set; }
        public string NomeSistema { get; set; }
        public string DescritivoSistema { get; set; }
        public bool OperacaoAtiva { get; set; }

        public virtual List<FeatureFlagViewModel> FeatureFlag { get; set; }
        public virtual List<IntencaoFuncionalidadeViewModel> IntencaoFuncionalidade { get; set; }
        public virtual List<UsuarioSistemaViewModel> UsuarioSistema { get; set; }
    }
}

