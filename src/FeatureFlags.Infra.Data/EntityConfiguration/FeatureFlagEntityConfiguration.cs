using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class FeatureFlagEntityConfiguration : IEntityTypeConfiguration<FeatureFlag>
    {
        public void Configure(EntityTypeBuilder<FeatureFlag> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => new { p.FeatureFlagId, p.SistemaId })
                .HasName("FeatureFlag_PK");

            builder.Property(p => p.NomeFeatureFlag)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.Property(p => p.DescricaoFeatureFlag)
                .IsRequired(false)
                .HasMaxLength(200)
                .HasColumnType("varchar");

            builder.Property(p => p.DataInicioVigencia)
                .IsRequired(false)
                .HasColumnType("date");

            builder.Property(p => p.DataFimVigencia)
                .IsRequired(false)
                .HasColumnType("date");

            builder.Property(p => p.FeatureFlagAtivada)
                .IsRequired()
                .HasDefaultValue(false);

            builder.HasOne(t => t.Sistema)
                .WithMany(t => t.FeatureFlag)
                .HasForeignKey(p => p.SistemaId)
                .HasConstraintName("FeatureFlag_Sistema_FK");
        }
    }
}
