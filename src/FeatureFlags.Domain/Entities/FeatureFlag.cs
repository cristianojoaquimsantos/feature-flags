using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    [ExcludeFromCodeCoverage]
	public class FeatureFlag: Entity, IAggregateRoot
    {
		public FeatureFlag(Guid sitemaId, 
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
		
		public FeatureFlag(Guid featureFlagId,
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

		public Guid FeatureFlagId { get; private set; }
		public Guid SistemaId { get; set; }
		public string NomeFeatureFlag { get; private set; }
		public string DescricaoFeatureFlag { get; private set; }
		public DateTime DataInicioVigencia { get; private set; }
		public DateTime? DataFimVigencia { get; private set; }
		public bool FeatureFlagAtivada { get; private set; }
		
		public virtual Sistema Sistema { get; set; }
		public virtual IList<AmbienteFeatureFlag> AmbienteFeatureFlag { get; set; }
		public virtual IntencaoFuncionalidadeFeatureFlag IntencaoFuncionalidadeFeatureFlag { get; set; }
		public virtual IList<UsuarioSistemaFeatureFlag> UsuarioSistemaFeatureFlag { get; set; }
    }
}

