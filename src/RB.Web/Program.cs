var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();
builder.AddNpgsqlDbContext<AppDbContext>("postgresdb");

var app = builder.Build();

app.UseHttpsRedirection();
app.Run();
