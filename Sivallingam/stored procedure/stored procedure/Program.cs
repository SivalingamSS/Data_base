using BUSINESSLAYER.Business;
using BUSINESSLAYER.Interface;
using DATALAYER.Data;
using DATALAYER.Interface;
using Microsoft.EntityFrameworkCore;
using StoreProcedure_Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SPDbcontext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("MVC6CrudConnectionString")));
builder.Services.AddTransient<IBusinessInterface, BusinessClass>();
builder.Services.AddTransient<IDataInterface, DataClass>();


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
