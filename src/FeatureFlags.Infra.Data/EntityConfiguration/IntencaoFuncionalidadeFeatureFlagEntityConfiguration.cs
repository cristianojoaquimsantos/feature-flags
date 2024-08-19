using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class IntencaoFuncionalidadeFeatureFlagEntityConfiguration : IEntityTypeConfiguration<IntencaoFuncionalidadeFeatureFlag>
    {
        public void Configure(EntityTypeBuilder<IntencaoFuncionalidadeFeatureFlag> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => new
            {
                p.IntencaoFuncionalidadeId,
                p.FeatureFlagId,
                p.SistemaId
            })
                .HasName("IntencaoFuncionalidadeFeatureFlag_PK");

            builder.HasOne(t => t.FeatureFlag)
                .WithOne(t => t.IntencaoFuncionalidadeFeatureFlag)
                .HasForeignKey<IntencaoFuncionalidadeFeatureFlag>(p => p.FeatureFlagId)
                .IsRequired()
                .HasConstraintName("IntencaoFuncionalidadeFeatureFlag_FeatureFlag_FK");

            builder.HasOne(t => t.IntencaoFuncionalidade)
                .WithOne(t => t.IntencaoFuncionalidadeFeatureFlag)
                .HasForeignKey<IntencaoFuncionalidadeFeatureFlag>(t => t.IntencaoFuncionalidadeId)
                .IsRequired()
                .HasConstraintName("IntencaoFuncionalidadeFeatureFlag_IntencaoFuncionalidade_FK");
        }
    }
}
