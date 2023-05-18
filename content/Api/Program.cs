

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok(new 
    {
        Application = "Improved Backstage Template",
        ServerTime = DateTimeOffset.Now
    });
});

await app.RunAsync();