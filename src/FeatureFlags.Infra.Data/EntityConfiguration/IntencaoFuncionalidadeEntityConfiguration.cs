using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class IntencaoFuncionalidadeEntityConfiguration : IEntityTypeConfiguration<IntencaoFuncionalidade>
    {
        public void Configure(EntityTypeBuilder<IntencaoFuncionalidade> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => new { p.IntencaoFuncionalidadeId, p.SistemaId })
                .HasName("IntencaoFuncionalidade_PK");

            builder.Property(p => p.DescricaoIntecaoFuncionalidade)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar");

            builder.HasOne(t => t.Sistema)
                .WithMany(t => t.IntencaoFuncionalidade)
                .HasForeignKey(p => p.SistemaId)
                .HasConstraintName("IntencaoFuncionalidade_Sistema_FK");
        }
    }
}
