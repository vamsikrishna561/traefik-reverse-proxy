var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/service2", () => "Hello World Service 2!");

app.Run();  
