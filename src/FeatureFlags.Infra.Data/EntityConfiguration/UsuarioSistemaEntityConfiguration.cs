using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class UsuarioSistemaEntityConfiguration : IEntityTypeConfiguration<UsuarioSistema>
    {
        public void Configure(EntityTypeBuilder<UsuarioSistema> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => new { p.UsuarioId, p.SistemaId })
                .HasName("UsuarioSistema_PK");            

            builder.HasOne(t => t.Sistema)
                .WithMany(t => t.UsuarioSistema)
                .HasForeignKey(p => p.SistemaId)
                .HasConstraintName("UsuarioSistema_Sistema_FK");

            builder.HasOne(t => t.Usuario)
                .WithMany(t => t.UsuarioSistema)
                .HasForeignKey(p => p.UsuarioId)
                .HasConstraintName("UsuarioSistema_Usuario_FK");
        }
    }
}
