using UnimedFESP.Domain.Core.Domain;

namespace FeatureFlags.Domain.Entities
{
    public class Usuario: Entity, IAggregateRoot
    {
        public Usuario(Guid usuarioId,
                       string nomeUsuario,
                       string loginUsuario)
        {
            UsuarioId = usuarioId;
            NomeUsuario = nomeUsuario;
            LoginUsuario = loginUsuario;
        }

        public Usuario(string nomeUsuario,
                       string loginUsuario)
        {            
            NomeUsuario = nomeUsuario;
            LoginUsuario = loginUsuario;
        }

        public Guid UsuarioId { get; private set; }
        public string NomeUsuario { get; private set; }
        public string LoginUsuario { get; private set; }

        public virtual IList<UsuarioSistema> UsuarioSistema { get; set; }
    }
}
