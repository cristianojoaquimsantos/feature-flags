using FeatureFlags.Domain.Core.Data;
using FeatureFlags.Domain.Core.Mediator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Infra.Data.EntityConfiguration;

namespace FeatureFlags.Infra.Data.Context
{
    public class FeatureFlagContext: DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IConfiguration _configuration;

        public FeatureFlagContext(DbContextOptions<FeatureFlagContext> options,
                                  IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Ambiente> Ambiente { get; set; }
        public DbSet<AmbienteFeatureFlag> AmbienteFeatureFlag { get; set; }
        public DbSet<FeatureFlag> FeatureFlag { get; set; }
        public DbSet<IntencaoFuncionalidade> IntencaoFuncionalidade { get; set; }
        public DbSet<IntencaoFuncionalidadeFeatureFlag> IntencaoFuncionalidadeFeatureFlag { get; set; }
        public DbSet<Sistema> Sistema { get; set; }
        public DbSet<UsuarioSistema> UsuarioSistema { get; set; }
        public DbSet<UsuarioSistemaFeatureFlag> UsuarioSistemaFeatureFlag { get; set; }

        public async Task<bool> Commit()
        {
            await _mediatorHandler.PublishDomainEvents(this).ConfigureAwait(false);

            var success = await SaveChangesAsync() > 0;

            return success;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany
                (e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfiguration(new AmbienteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AmbienteFeatureFlagEntityConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureFlagEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IntencaoFuncionalidadeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IntencaoFuncionalidadeFeatureFlagEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SistemaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioSistemaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioSistemaFeatureFlagEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
