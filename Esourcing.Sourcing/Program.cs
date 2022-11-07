using Esourcing.Sourcing.Settings;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.








//builder.Services.Con ConfigureServices(IServiceCollection services)
//{
//    Services.Configure<SourcingDatabaseSettings>(Configuration.GetSection(nameof(SourcingDatabaseSettings)));
//    services.AddSingleton<SourcingDatabaseSettings>();
//}



builder.Services.AddControllers();
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
