using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FarmingDbContext>(options =>
    options.UseSqlite("Data Source=farming.db"));

builder.Services.AddControllers();

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

app.MapControllers();

app.Run();