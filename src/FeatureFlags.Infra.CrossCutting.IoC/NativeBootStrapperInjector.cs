using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FeatureFlags.Application.AppServices.Implementation;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Repository;

namespace FeatureFlags.Infra.CrossCutting.IoC
{
    public static class NativeBootStrapperInjector
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Application
            services.AddScoped<IAmbienteAppService, AmbienteAppService>();
            services.AddScoped<IAmbienteFeatureFlagAppService, AmbienteFeatureFlagAppService>();
            services.AddScoped<IFeatureFlagAppService, FeatureFlagAppService>();
            services.AddScoped<IIntencaoFuncionalidadeAppService, IntencaoFuncionalidadeAppService>();
            services.AddScoped<IIntencaoFuncionalidadeFeatureFlagAppService, IntencaoFuncionalidadeFeatureFlagAppService>();
            services.AddScoped<ISistemaAppService, SistemaAppService>();
            services.AddScoped<IUsuarioSistemaAppService, UsuarioSistemaAppService>();
            services.AddScoped<IUsuarioSistemaFeatureFlagAppService, UsuarioSistemaFeatureFlagAppService>();

            //Application
            services.AddScoped<IAmbienteRepository, AmbienteRepository>();
            services.AddScoped<IAmbienteFeatureFlagRepository, AmbienteFeatureFlagRepository>();
            services.AddScoped<IFeatureFlagRepository, FeatureFlagRepository>();
            services.AddScoped<IIntencaoFuncionalidadeRepository, IntencaoFuncionalidadeRepository>();
            services.AddScoped<IIntencaoFuncionalidadeFeatureFlagRepository, IntencaoFuncionalidadeFeatureFlagRepository>();
            services.AddScoped<ISistemaRepository, SistemaRepository>();
            services.AddScoped<IUsuarioSistemaRepository, UsuarioSistemaRepository>();
            services.AddScoped<IUsuarioSistemaFeatureFlagRepository, UsuarioSistemaFeatureFlagRepository>();
        }
    }
}
