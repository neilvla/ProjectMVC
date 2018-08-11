using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;

namespace AgroAppWS.Middleware
{
    public static class ProductService
    {

        public static IServiceCollection AddRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IFileServerProvider>(new FileServerProvider(
       new List<FileServerOptions>
       {
            new FileServerOptions
            {
                FileProvider = new PhysicalFileProvider("C:\\recursos\\"),
                RequestPath = new PathString("/StaticFiles"),
                EnableDirectoryBrowsing = true // you make this true or false.
            }
       }));
            return services;
        }
    }
}
