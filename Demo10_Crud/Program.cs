using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Demo10_Crud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<EmpDbContext>(options => options.UseSqlServer("name=myConStr"));

            builder.Services.AddCors(corsoption => {
                corsoption.AddPolicy("IET", (corspolicy) => {
                    corspolicy.WithOrigins("*").WithMethods("*").WithHeaders("*");
                });
            });






          

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

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
