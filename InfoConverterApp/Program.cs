
using InfoConverterApp.Messange;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/", () => "pong");
app.MapGet("/ping", async (context) =>
{
    await context.Response.WriteAsync("Pong");
});

app.MapGet("/status", async (context) =>
{
    Messange.ServerStatus serverStatus = new Messange.ServerStatus("OK", DateTime.Now, System.Net.Dns.GetHostName());
});
app.MapGet("/info", async (context) =>
{
    await context.Response.WriteAsync("Methods :/convert(converter)");
});


app.Run();
