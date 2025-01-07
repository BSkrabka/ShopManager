namespace SM.WebApi;

public static class SwaggerConfiguration
{
    //public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    //{
    //    services.AddSwaggerGen(c =>
    //    {
    //        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Configublator" });
    //        c.AddSecurityDefinition("Bearer",
    //            new OpenApiSecurityScheme
    //            {
    //                Description = "JWT Authorization header using the Bearer scheme.",
    //                Type = SecuritySchemeType.Http,
    //                Scheme = "bearer"
    //            });
    //        c.AddSecurityRequirement(new OpenApiSecurityRequirement
    //        {
    //            {
    //                new OpenApiSecurityScheme
    //                {
    //                    Reference = new OpenApiReference
    //                    {
    //                        Id = "Bearer",
    //                        Type = ReferenceType.SecurityScheme
    //                    }
    //                },
    //                new List<string>()
    //            }
    //        });

    //        //Needed to properly match a simple route parameter to a ParameterRequest
    //        c.MapType(typeof(ParameterRequest<>), () => new OpenApiSchema { Type = "string" });

    //        try
    //        {
    //            var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //            var path = Path.Combine(AppContext.BaseDirectory, xmlFile);
    //            c.IncludeXmlComments(path);
    //        }
    //        catch
    //        {
    //            /*
    //             * Exception hidden on purpose. The project needs to have the  <GenerateDocumentationFile>True</GenerateDocumentationFile> flag
    //             * set in the .csproj file. If it isn't there we don't want to blow up the entire project and we just keep the comments  disabled instead.
    //             */
    //        }
    //    });

    //    return services;
    //}
}
