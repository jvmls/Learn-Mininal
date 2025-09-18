var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login", (Lean.DTOs.LoginDTO LoginDTO) =>
{
    if (LoginDTO.UserName == "admin" && LoginDTO.Password == "admin")
    {
        return Results.Ok("Login successful");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.Run();
