using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApplicationDistribution;
using WebApplicationDistribution.Data;
using WebApplicationDistribution.Middlewares;
using Microsoft.EntityFrameworkCore;
using WebApplicationDistribution.Contracts.Entrants;
using WebApplicationDistribution.Contracts.Specialties;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors();

// Add services to the container.
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IEntrantService, EntrantService>();
builder.Services.AddScoped<ISpecialtyService, SpecialtyService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EntrantContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

app.UseCors(config =>
{
    config.AllowAnyOrigin();
    config.AllowAnyHeader();
    config.AllowAnyMethod();
});

app.UseCors(options =>
options.WithOrigins("http://localhost:3000")
.AllowAnyMethod()
.AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<JwtMiddleware>();

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
