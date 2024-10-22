using Microsoft.EntityFrameworkCore;
using Tienda.Abstraccion.Repositorio;
using Tienda.Implementaciones.Repositorio;
using Tienda.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TiendaContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnetion")));
builder.Services.AddScoped<IRepositorioCliente, RepositorioCliente>();
builder.Services.AddScoped<IRepositorioDetProducto, RepositorioDetProducto>();
builder.Services.AddScoped<IRepositorioFactura, RepositorioFactura>();
builder.Services.AddScoped<IRepositorioFoto, RepositorioFoto>();
builder.Services.AddScoped<IRepositorioProducto, RepositorioProducto>();

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
