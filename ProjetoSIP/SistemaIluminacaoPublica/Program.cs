using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para usar controllers
builder.Services.AddControllers();

// Configura o Swagger para documentação da API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Remover o redirecionamento HTTPS
// app.UseHttpsRedirection();

app.UseRouting(); // Adicione isso para garantir que o roteamento esteja configurado

app.UseAuthorization();

app.MapControllers();

app.Run();
