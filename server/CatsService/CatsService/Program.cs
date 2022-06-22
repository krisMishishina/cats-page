var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/cats", () => {
    return "Cats!";
});

app.MapGet("/articles", () =>
{
    return ;
});


app.Run();