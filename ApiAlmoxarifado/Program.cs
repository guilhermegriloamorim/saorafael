using AlmoxarifadoRepositories.Data;
using AlmoxarifadoRepositories.Interfaces;
using AlmoxarifadoService.Dominio;
using AlmoxarifadoService.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//My services
builder.Services.AddDbContext<AlmoxarifadoDbContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("local")), ServiceLifetime.Scoped);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IRepositoryBarrca, RepositoryBarraca>();
builder.Services.AddScoped<IServiceBarraca, ServiceBarraca>();

builder.Services.AddScoped<IRepositoryItem, RepositoryItem>();
builder.Services.AddScoped<IServiceItem, ServiceItem>();

builder.Services.AddScoped<IRepositoryItemEntrada, RepositoryItemEntrada>();
builder.Services.AddScoped<IServiceItemEntrada, ServiceItemEntrada>();

builder.Services.AddScoped<IRepositoryItemSaida, RepositoryItemSaida>();
builder.Services.AddScoped<IServiceItemSaida, ServiceItemSaida>();

builder.Services.AddScoped<IRepositoryItemSaidaViewModel, RepositoryItemSaidaViewModel>();
builder.Services.AddScoped<IServiceItemSaidaViewModel, ServiceItemSaidaViewModel>();

builder.Services.AddScoped<IRepositoryUnidadeMedidaViewModel, RepositoryUnidadeMedidaViewModel>();
builder.Services.AddScoped<IServiceUnidadeMedidaViewModel, ServiceUnidadeMedidaViewModel>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseCors(policy =>
    policy.AllowAnyOrigin()
    .AllowAnyMethod()
      .AllowAnyHeader()
);

app.UseAuthorization();

app.MapControllers();

app.Run();