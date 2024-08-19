using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FeatureFlags.Services.Api.Extension
{
    public class DocumentFilterLowerCaseExtension : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var paths = swaggerDoc.Paths.ToDictionary(
                path => string.Join('/', path.Key.Split('/').Select(p => p.ToLowerInvariant())),
                path => path.Value
            );

            swaggerDoc.Paths = new OpenApiPaths();

            foreach (var pathItem in paths)
            {
                swaggerDoc.Paths.Add(pathItem.Key, pathItem.Value);
            }
        }
    }
}
