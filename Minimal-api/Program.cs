using Minimal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
  if (loginDTO.Email == "adm@test.com" && loginDTO.Senha == "123456")
  {
    return Results.Ok("Login com sucesso");
  }
  else
  {
    return Results.Unauthorized();
  }
});

app.Run();