using Lean.DTOs;
using Learn.Infraestrutura.DB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(
    options => options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    )
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login", (LoginDTO LoginDTO) =>
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
