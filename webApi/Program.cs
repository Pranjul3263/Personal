using Microsoft.EntityFrameworkCore;
using webApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//==================== add additional ===========================

var conf = builder.Configuration;
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;

var scons = configuration["ConnectionStrings:DefaultConnection"];

IServiceCollection serviceCollection = builder.Services.AddDbContext<AppDbConst>(options => options.UseSqlServer(scons, opt =>
 opt.CommandTimeout(18000)));
//builder.Services.AddScoped<IAuditOperation, AuditOperation>();
MasterServices.ConfigureServices(builder.Services);



//==== add additional ======


builder.Services.AddDbContext<AppDbConst>(options=> options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
