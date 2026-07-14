var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Mayuri welcome in .NET WebServer!");

app.Run();
