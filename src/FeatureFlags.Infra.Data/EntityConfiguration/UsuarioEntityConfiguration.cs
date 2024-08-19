using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Infra.Data.EntityConfiguration
{
    public class UsuarioEntityConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Ignore(p => p.Id);

            builder.HasKey(p => p.UsuarioId)
                .HasName("Usuario_PK");

            builder.Property(p => p.NomeUsuario)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(p => p.LoginUsuario)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");
        }
    }
}
