using Microsoft.Extensions.FileProviders;
using System.Net.NetworkInformation;

namespace CoreShopping.WebUI.Middlewares
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder CustomStaticFiles(this IApplicationBuilder app)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "node_modules");//  C:\Users\Emre\source\repos\CoreShopping\CoreShopping.WebUI\node_modules sonundaki oluşturacağımız "node_modules"

            var options = new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(path),
                RequestPath = "/modules" // bunu istediğimizde yukarıdaki uzun yolu getir. uzun uzun yazmamak için yaptık.
            };

            app.UseStaticFiles(options);
            return app;
        }
    }
}
