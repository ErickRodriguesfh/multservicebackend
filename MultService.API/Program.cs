using MultService.API.Configuration;
using MultService.Infrastructure.Migrations;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();


builder.Services.AddControllers();

builder.Services.InstallServices(
    builder.Configuration, typeof(IServiceInstaller).Assembly);

builder.Services.AddSwaggerGen();

var app = builder.Build();




app.UseSwagger();
app.UseSwaggerUI();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

MigrateDatabase();

app.Run();

void MigrateDatabase()
{
    var connectionString = builder.Configuration.GetConnectionString("Connection");
    var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
    DatabaseMigration.MigrationDatabase(serviceScope.ServiceProvider);
}