using Microsoft.EntityFrameworkCore;
using MyRestaurantApi;
using MyRestaurantApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyRestaurantApiContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MyRestaurantApiContext") ?? throw new InvalidOperationException("Connection string 'MyRestaurantApiContext' not found.")));

// Add services to the container.
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

app.MapContactEndpoints();

app.MapMenuItemOrderedEndpoints();

app.MapTogoOrderEndpoints();

app.MapMenuItemEndpoints();

app.Run();


