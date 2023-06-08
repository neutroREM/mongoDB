using BookStoreApi.Interfaces;
using BookStoreApi.Services;
using BookStoreApi.Utilities.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
[assembly: ApiController]
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<BookStoreDatabaseSettings>(
    builder.Configuration.GetSection("BookStoreDatabase"));

//MongoDB
builder.Services.AddSingleton<IUtilitiesService, UtilitiesService>();
builder.Services.AddSingleton<BooksService>();
builder.Services.AddSingleton<UsersService>();


//AutoMapper
builder.Services.AddAutoMapper(typeof(MapperProfile));


//Autentication -Login-



//
builder.Services.AddControllers()
    .AddJsonOptions( 
    options => options.JsonSerializerOptions.PropertyNamingPolicy = null);


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
