using System.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using Middleware.Middlewares;
using Middleware.Services;
using Middleware.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// DI
builder.Services.AddHttpClient<IBookService, BookService>("books", client =>
{
    client.BaseAddress = new Uri("http://externmalapi");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
});


builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IVersionService, VersionService>();
builder.Services.AddScoped<IVerseService, VerseService>();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = $"RESTful Bible API",
            Description = $"API que realiza chamadas http a API RESTful Bible",
            Version = "v1",
            Contact = new OpenApiContact()
            {
                Name = "Haroldo Vinente", Url = new Uri("https://github.com/HaroldoFV"),
            },
            License = new OpenApiLicense() {Name = "MIT", Url = new Uri("http://opensource.org/licenses/MIT"),}
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();