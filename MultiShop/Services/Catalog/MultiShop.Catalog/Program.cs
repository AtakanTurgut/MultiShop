using Microsoft.Extensions.Options;
using MultiShop.Catalog.Infrastructure.Extensions;
using MultiShop.Catalog.Settings;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Services Extensions
builder.Services.ConfigureServiceRegistration();

// AutoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Database Configure
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

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
