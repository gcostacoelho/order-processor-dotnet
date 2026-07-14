using Api.src.Configs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterServices();
builder.Services.RegisterRepositories();
builder.Services.RegisterSingletons(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
