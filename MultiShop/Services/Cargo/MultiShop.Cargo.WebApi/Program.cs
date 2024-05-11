using MultiShop.Cargo.BusinessLayer.Extensions;
using MultiShop.Cargo.DataAccessLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Database Context
builder.Services.AddDbContext<CargoContext>();

// Repositories - Extensions
builder.Services.ConfigureRepositoryRegistration();
// Services - Extensions
builder.Services.ConfigureServiceRegistration();

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
