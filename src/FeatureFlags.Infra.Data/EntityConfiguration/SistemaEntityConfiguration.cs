using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class SistemaEntityConfiguration : IEntityTypeConfiguration<Sistema>
    {
        public void Configure(EntityTypeBuilder<Sistema> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => p.SistemaId)
                .HasName("Sistema_PK");

            builder.Property(p => p.NomeSistema)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.Property(p => p.DescritivoSistema)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar");

            builder.Property(p => p.DescritivoSistema)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
