using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project1Phase3.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Project1DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Project1DbContext") ?? throw new InvalidOperationException("Connection string 'Project1DbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
