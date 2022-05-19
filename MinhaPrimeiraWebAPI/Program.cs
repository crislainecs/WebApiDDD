using Microsoft.EntityFrameworkCore;
using PrimeiraWebApi.Application.AppServices;
using PrimeiraWebApi.Application.Interfaces;
using PrimeiraWebApi.Infra.Data;
using PrimeiraWebApi.Infra.Interfaces;
using PrimeiraWebApi.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IProdutoAppService, ProdutoAppService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("WebApiConnection");
builder.Services.AddDbContext<WebApiContext>(options =>
    options.UseSqlServer(connectionString)); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
