using FeatureFlags.Domain.Core;

namespace FeatureFlags.Domain.Entities
{
    public class UsuarioSistema: Entity, IAggregateRoot
    {
        protected UsuarioSistema() { }

        public UsuarioSistema(Guid usuarioId,
                              Guid sitemaId)
        {
            UsuarioId = usuarioId;
            SistemaId = sitemaId;
        }

        public Guid UsuarioId { get; private set; }
        public Guid SistemaId { get; private set; }
        
        public virtual Usuario Usuario { get; set; }
        public virtual Sistema Sistema { get; set; }
        public virtual List<UsuarioSistemaFeatureFlag> UsuarioSistemaFeatureFlag { get; set; }
    }
}
