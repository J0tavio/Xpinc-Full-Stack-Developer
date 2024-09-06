using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Minimal_api.Dominio.DTOs;
using Minimal_api.Dominio.Interfaces;
using Minimal_api.Dominio.Servicos;
using Minimal_api.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<iAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options =>
{
  options.UseMySql(builder.Configuration.GetConnectionString("mysql"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, iAdministradorServico administradorServico) =>
{
  if (administradorServico.Login(loginDTO) != null)
  {
    return Results.Ok("Login com sucesso");
  }
  else
  {
    return Results.Unauthorized();
  }
});

app.Run();