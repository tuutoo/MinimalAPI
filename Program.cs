using Microsoft.EntityFrameworkCore;
using MinimalAPI.Data;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var dbConnectionBuilder = new NpgsqlConnectionStringBuilder();
dbConnectionBuilder.ConnectionString = builder.Configuration.GetConnectionString("PgDbConnection");
dbConnectionBuilder.Username = builder.Configuration["Username"];
dbConnectionBuilder.Password = builder.Configuration["Password"];

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(dbConnectionBuilder.ConnectionString));
builder.Services.AddScoped<ICommandRepo, CommandRepo>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
