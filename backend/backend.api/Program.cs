using System.Text.Json.Serialization;
using backend.api.DbInfrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PlemionaDbContext>(opts =>
{
    opts.UseNpgsql(
        builder.Configuration["ConnectionStrings:PlemionaDbConnection"]);
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers().AddJsonOptions(x =>
   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


SeedData.SeedDatabase(app);

app.Run();

