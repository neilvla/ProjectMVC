using Microsoft.AspNetCore.Builder;

namespace AgroAppWeb.Middleware
{
    public static class FileServerProviderExtensions
    {
        public static IApplicationBuilder UseFileServerProvider(this IApplicationBuilder application, IFileServerProvider fileServerprovider)
        {
            foreach (var option in fileServerprovider.FileServerOptionsCollection)
            {
                application.UseFileServer(option);
            }
            return application;
        }
    }
}
