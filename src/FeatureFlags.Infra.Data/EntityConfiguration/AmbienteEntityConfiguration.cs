using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class AmbienteEntityConfiguration : IEntityTypeConfiguration<Ambiente>
    {
        public void Configure(EntityTypeBuilder<Ambiente> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => p.AmbienteId)
                .HasName("Ambiente_PK");

            builder.Property(p => p.NomeAmbiente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.Property(p => p.DescricaoAmbiente)
                .IsRequired(false)
                .HasMaxLength(200)
                .HasColumnType("varchar");

            builder.Property(p => p.AmbienteAtivo)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
