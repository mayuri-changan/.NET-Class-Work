namespace Demo01_ET;
public class Program
{
    public static void Main(string[] args)
    {


        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => "Hello Mayuri!!!!!");
        app.Use(async (httpcontext, next) =>
        {
            await httpcontext.Response.WriteAsync("Hello Mayurii");
            await httpcontext.Response.WriteAsync("\nHello.NET");
            next();
            await httpcontext.Response.WriteAsync("\nstill getting this ");

        });
        app.Use(async (httpcontext, next) => {
            await httpcontext.Response.WriteAsync("\nhello Java");
            await httpcontext.Response.WriteAsync("\nbye bye c++");
            next(httpcontext);
            await httpcontext.Response.WriteAsync("\ndont disturb me!!!");
        });
        app.Run(async (httpcontext) =>
        {
            await httpcontext.Response.WriteAsync("\nover now!!!!");
        });

        app.Run();
    }
}