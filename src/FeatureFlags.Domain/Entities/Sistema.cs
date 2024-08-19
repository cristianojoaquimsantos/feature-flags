using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Sistema: Entity, IAggregateRoot
    {
		public Sistema(Guid sistemaId,
					   string nomeSistema,
					   string descritivoSistema,
					   bool operacaoAtiva)
		{
			SistemaId = sistemaId;
			NomeSistema = nomeSistema;
			DescritivoSistema = descritivoSistema;
			OperacaoAtiva = operacaoAtiva;
		}

		public Guid SistemaId{ get; private set; }
		public string NomeSistema{ get; private set; }
		public string DescritivoSistema{ get; private set; }
		public bool OperacaoAtiva{ get; private set; }
		
		public virtual List<FeatureFlag> FeatureFlag { get; set; }
		public virtual List<IntencaoFuncionalidade> IntencaoFuncionalidade { get; set; }
		public virtual List<UsuarioSistema> UsuarioSistema { get; set; }
	}
}

