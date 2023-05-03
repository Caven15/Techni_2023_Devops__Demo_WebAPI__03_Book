using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injection du service de la DAL
builder.Services.AddSingleton<ILivreRepository, LivreDalRepository>();

// Injection du service de la Bll
builder.Services.AddScoped<ILivreService, LivreService>();

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
