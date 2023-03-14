using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.Services;
using TaskManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Register Configuration
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Database Service

builder.Services.AddDbContext<TaskDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("Presentation")));
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ITaskService, TaskService>();

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
