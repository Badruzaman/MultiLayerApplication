using Microsoft.EntityFrameworkCore;
using MultiLayerApplication.Api.CustomExceptionModel;
using MultiLayerApplication.DAL;
using MultiLayerApplication.DAL.Repository;
using MultiLayerApplication.Domain.Abstractions;
using MultiLayerApplication.Service.Sevices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(CustomExceptionFilter));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbConnection")));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();



var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseExceptionHandler(new ExceptionHandlerOptions
//{
//    ExceptionHandler = new CustomExceptionFilter().OnException
//});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
