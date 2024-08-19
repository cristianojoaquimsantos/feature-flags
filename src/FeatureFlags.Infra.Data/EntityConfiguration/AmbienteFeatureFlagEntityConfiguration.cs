using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class AmbienteFeatureFlagEntityConfiguration : IEntityTypeConfiguration<AmbienteFeatureFlag>
    {
        public void Configure(EntityTypeBuilder<AmbienteFeatureFlag> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => new { p.AmbienteId, p.FeatureFlagId, p.SistemaId })
                .HasName("AmbienteFeatureFlag_PK");

            builder.Property(p => p.UsuarioId)
                .IsRequired(false);

            builder.HasOne(t => t.Ambiente)
                .WithMany(t => t.AmbienteFeatureFlag)
                .HasForeignKey(p => p.AmbienteId)
                .HasConstraintName("Ambiente_AmbienteFeatureFlag_PK");

            builder.HasOne(t => t.FeatureFlag)
                .WithMany(t => t.AmbienteFeatureFlag)
                .HasForeignKey(p => p.FeatureFlagId)
                .HasConstraintName("FeatureFlag_AmbienteFeatureFlag_PK");
        }
    }
}
