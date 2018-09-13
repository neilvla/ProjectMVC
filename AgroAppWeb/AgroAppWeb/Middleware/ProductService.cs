using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;

namespace AgroAppWeb.Middleware
{
    public static class ProductService
    {

        public static IServiceCollection AddRegistration(this IServiceCollection services, IConfiguration configuration, IHostingEnvironment env)
        {
            //Development
            if (env.IsDevelopment())
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
            }
            if (env.IsProduction())
            {
                services.AddSingleton<IFileServerProvider>(new FileServerProvider(
               new List<FileServerOptions>
               {
                    new FileServerOptions
                    {
                        FileProvider = new PhysicalFileProvider("H:\\root\\home\\neilvla-001\\www\\site1\\recursos\\"),
                        //FileProvider = new PhysicalFileProvider("C:\\recursos\\"),
                        RequestPath = new PathString("/StaticFiles"),
                        EnableDirectoryBrowsing = true // you make this true or false.
                    }

               }));
            }
            return services;
        }
    }
}
