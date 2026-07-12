namespace Demo7_LayoutPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // images, bootstrap, js, css etc
            app.UseStaticFiles();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
