using Microsoft.AspNetCore.Authentication.JwtBearer;
using MultiShop.Order.Application.Extensions;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Persistence.Context;
using MultiShop.Order.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Protection - Authentication Authorization
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServiceUrl"];
    opt.Audience = "ResourceOrder";
    opt.RequireHttpsMetadata = false;
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Context
builder.Services.AddDbContext<OrderContext>();

// CQRS Registiration
builder.Services.ConfigureCQRSRegistiration();

// Mediator Registiration
builder.Services.ConfigureMediatorRegistiration(builder.Configuration);

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

// Protection - Authentication Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
