using System.Text.Json.Serialization;
using AeC.Application.Mapper;
using AeC.Application.Services.Aeroporto;
using AeC.Application.Services.Cidade;
using AeC.Application.Services.Interfaces;
using AeC.Domain.Interfaces.Repositories;
using AeC.Infra.Context;
using AeC.Infra.Repositories;
using AeC.Services.ExternalApis.BrasilApi;
using AeC.Services.interfaces.BrasilApi;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
        
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IApplicationServiceAeroporto, ApplicationServiceAeroporto>();
builder.Services.AddScoped<IApplicationServiceCidade, ApplicationServiceCidade>();

builder.Services.AddScoped<IRepositoryAeroporto, RepositoryAeroporto>();
builder.Services.AddScoped<IRepositoryCidade, RepositoryCidade>();
builder.Services.AddScoped<IRepositoryLog, RepositoryLog>();

builder.Services.AddScoped<IApiExternaClima, ApiExternaClima>();

builder.Services.AddDbContext<DbContextAec>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ContextConnectionstring")));

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
