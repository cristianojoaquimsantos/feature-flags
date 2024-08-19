using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class UsuarioSistemaFeatureFlagEntityConfiguration : IEntityTypeConfiguration<UsuarioSistemaFeatureFlag>
    {
        public void Configure(EntityTypeBuilder<UsuarioSistemaFeatureFlag> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => new
            {
                p.UsuarioId,
                p.SistemaId,
                p.FeatureFlagId
            })
                .HasName("UsuarioSistemaFeatureFlag_PK");

            builder.HasOne(t => t.UsuarioSistema)
                .WithMany(t => t.UsuarioSistemaFeatureFlag)
                .HasForeignKey(p => new { p.UsuarioId, p.SistemaId })
                .HasConstraintName("UsuarioSistemaFeatureFlag_UsuarioSistema_FK");

            builder.HasOne(t => t.FeatureFlag)
                .WithMany(t => t.UsuarioSistemaFeatureFlag)
                .HasForeignKey(p => new { p.FeatureFlagId, p.SistemaId })
                .HasConstraintName("UsuarioSistemaFeatureFlag_FeatureFlag_FK");
        }
    }
}
