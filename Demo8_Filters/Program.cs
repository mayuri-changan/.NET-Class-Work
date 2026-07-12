using Microsoft.AspNetCore.Mvc.Filters;

namespace Demo8_Filters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddExceptionHandler<ExceptionFilter>();
            builder.Services.AddSession();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Exception/Error");
            }
            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
