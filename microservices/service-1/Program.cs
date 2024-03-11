var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/service1", () => "Hello World Service 1!");

app.Run();
