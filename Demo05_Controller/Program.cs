namespace Demo05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
                name: "Capge",
                pattern: "{controller=Demo}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
