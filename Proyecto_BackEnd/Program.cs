using Microsoft.EntityFrameworkCore;
using Proyecto_BackEnd.Context;
using Proyecto_BackEnd.Controllers;
using Proyecto_BackEnd.Repository;
using Proyecto_BackEnd.Service;
using System.Configuration;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*");
                          policy.WithHeaders("*");
                          policy.WithMethods("*");
                      });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserController>();
builder.Services.AddScoped<CajeroRepository>();
builder.Services.AddScoped<CajeroService>();
builder.Services.AddScoped<CajeroController>();
builder.Services.AddScoped<CallRepository>();
builder.Services.AddScoped<CallService>();
builder.Services.AddScoped<CallController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
