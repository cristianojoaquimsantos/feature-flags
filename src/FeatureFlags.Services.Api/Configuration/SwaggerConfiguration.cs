using FeatureFlags.Services.Api.Extension;
using Microsoft.OpenApi.Models;

namespace FeatureFlags.Services.Api.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v3", new OpenApiInfo
                {
                    Version = "v3",
                    Title = "API Feature Flags",
                    Description = "API de Serviços para Integração de Sistemas com o Fluxo de Feature Flags",
                    Contact = new OpenApiContact { Name = "Arquitetura FESP", Email = "cristiano.joaquim@gmail.com" },
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://www.codelinq.com.br") }
                });


                OpenApiSecurityScheme securityDefinition = new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    BearerFormat = "JWT",
                    Scheme = "bearer",
                    Description = "Autenticação baseada em Json Web Token (JWT), favor inserir o JWT token gerado pelo Keycloak:",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                };
                s.AddSecurityDefinition("jwt_auth", securityDefinition);

                OpenApiSecurityScheme securityScheme = new OpenApiSecurityScheme()
                {
                    Reference = new OpenApiReference()
                    {
                        Id = "jwt_auth",
                        Type = ReferenceType.SecurityScheme
                    }
                };

                OpenApiSecurityRequirement securityRequirements = new OpenApiSecurityRequirement()
                {
                    {securityScheme, new string[] { }},
                };
                s.AddSecurityRequirement(securityRequirements);
                s.DocumentFilter<DocumentFilterLowerCaseExtension>();
            });
        }

        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentException(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v3/swagger.json", "v3");
            });
        }
    }
}
