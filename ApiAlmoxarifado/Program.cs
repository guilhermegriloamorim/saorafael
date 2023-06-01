using AlmoxarifadoRepositories.Data;
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

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
);

app.UseAuthorization();

app.MapControllers();

app.Run();