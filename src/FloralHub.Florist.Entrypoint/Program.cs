WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/",
    () =>
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Test console message");
        Console.WriteLine("--------------------");
    });

app.Run();
