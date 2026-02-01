using System.Data;

using Microsoft.Data.SqlClient;

using Todoist.Infrastructure.Repositories.Task;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new Exception("Connection string DefaultConnection not found!");
}

//builder.Services.AddScoped<IDbConnection, SqlConnection>();

builder.Services.AddScoped<IDbConnection>(
    sp => new SqlConnection(connectionString));

// Other services
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
