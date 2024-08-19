using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Application.ViewModel
{
    [ExcludeFromCodeCoverage]
    public class FeatureFlagViewModel
    {
        public FeatureFlagViewModel(Guid sitemaId,
                           string nomeFeatureFlag,
                           string descricaoFeatureFlag,
                           DateTime dataInicioVigencia,
                           DateTime? dataFimVigencia,
                           bool featureFlagAtivida)
        {
            FeatureFlagId = Guid.NewGuid();

            SistemaId = sitemaId;
            NomeFeatureFlag = nomeFeatureFlag;
            DescricaoFeatureFlag = descricaoFeatureFlag;
            DataInicioVigencia = dataInicioVigencia;
            DataFimVigencia = dataFimVigencia;
            FeatureFlagAtivada = featureFlagAtivida;
        }

        public FeatureFlagViewModel(Guid featureFlagId,
                           Guid sitemaId,
                           string nomeFeatureFlag,
                           string descricaoFeatureFlag,
                           DateTime dataInicioVigencia,
                           DateTime? dataFimVigencia,
                           bool featureFlagAtivada)
        {
            FeatureFlagId = featureFlagId;
            SistemaId = sitemaId;
            NomeFeatureFlag = nomeFeatureFlag;
            DescricaoFeatureFlag = descricaoFeatureFlag;
            DataInicioVigencia = dataInicioVigencia;
            DataFimVigencia = dataFimVigencia;
            FeatureFlagAtivada = featureFlagAtivada;
        }

        public Guid FeatureFlagId { get; set; }
        public Guid SistemaId { get; set; }
        public string NomeFeatureFlag { get; set; }
        public string DescricaoFeatureFlag { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public bool FeatureFlagAtivada { get; set; }

        public virtual SistemaViewModel Sistema { get; set; }
        public virtual IList<AmbienteFeatureFlagViewModel> AmbienteFeatureFlag { get; set; }
        public virtual IntencaoFuncionalidadeFeatureFlag IntencaoFuncionalidadeFeatureFlag { get; set; }
        public virtual IList<UsuarioSistemaFeatureFlagViewModel> UsuarioSistemaFeatureFlag { get; set; }
    }
}

