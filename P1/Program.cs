using P1.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace P1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Add MVC & API Controllers support
            builder.Services.AddControllersWithViews();

            // 2. Connect directly to the connection string inside appsettings.json
            builder.Services.AddDbContext<EmpDbContext>(options =>
                options.UseSqlServer("name=ConnectionStrings:EmpDbContext"));

            // 3. Configure CORS security rules
            builder.Services.AddCors(CorsOption =>
            {
                CorsOption.AddPolicy("IET", (CorsPolicy) =>
                {
                    CorsPolicy.WithOrigins("*").WithMethods("*").WithHeaders("*");
                });
            });

            var app = builder.Build();

            // HTTP request pipeline configuration
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseRouting();

            // Apply CORS policy before Authorization
            app.UseCors("IET");
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}