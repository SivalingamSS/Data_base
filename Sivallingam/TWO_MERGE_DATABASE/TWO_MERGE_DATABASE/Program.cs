using Business.two.tables.Interface;
using Business_two_tables_business;
using Microsoft.EntityFrameworkCore;
using TWO_TABLES_DATA.DATA;
using TWO_TABLES_DATA.Interface;
using TWO_TABLES_ENTITY;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TwotablesDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<Ibusinesslayertable, businesslayertable>();
builder.Services.AddTransient<Idatalayer, Datalayertable>();


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
