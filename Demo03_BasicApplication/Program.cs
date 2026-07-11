using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Demo03_BasicApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register MVC services
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Enable routing
            app.UseRouting();

            // Default route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Demo}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}