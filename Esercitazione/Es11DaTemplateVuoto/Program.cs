using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace Es11DaTemplateVuoto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // aggiunta serizio MVC
            builder.Services.AddMvc();
            
            // builder.Services.AddControllersWithViews();
            //---
            var app = builder.Build();

            app.UseRouting();
            
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapDefaultControllerRoute();
            //});

            ////--prima Alternativa
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Cliente}/{action=index}/{id?}");
            });

            ////-- seconda alternativa
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Cliente}/{action=index}/{id?}");
                

            app.Run();
        }
    }
}