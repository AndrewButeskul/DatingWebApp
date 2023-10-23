using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connetionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<DatingContext>(opt => opt.UseSqlite(connetionString));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
