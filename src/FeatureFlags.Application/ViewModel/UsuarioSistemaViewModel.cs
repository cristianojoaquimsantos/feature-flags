namespace FeatureFlags.Application.ViewModel
{
    public class UsuarioSistemaViewModel
    {
        protected UsuarioSistemaViewModel() { }

        public UsuarioSistemaViewModel(Guid usuarioId,
                              Guid sitemaId,
                              string nomeUsuario,
                              string loginUsuario)
        {
            UsuarioId = usuarioId;
            SistemaId = sitemaId;
            NomeUsuario = nomeUsuario;
            LoginUsuario = loginUsuario;
        }

        public Guid UsuarioId { get; set; }
        public Guid SistemaId { get; set; }
        public string NomeUsuario { get; set; }
        public string LoginUsuario { get; set; }

        public virtual SistemaViewModel Sistema { get; set; }
        public virtual List<UsuarioSistemaFeatureFlagViewModel> UsuarioSistemaFeatureFlag { get; set; }
    }
}
