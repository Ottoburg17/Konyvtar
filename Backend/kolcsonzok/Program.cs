using Microsoft.EntityFrameworkCore;
using kolcsonzok;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataService>(options => {
    var connectionString = builder.Configuration.GetConnectionString("Mariadb");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var origin = "*";
builder.Services.AddCors(options => {
    options.AddPolicy(name: origin,
    policy => {
        policy
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:4200");
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();     
}



app.UseCors(origin);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
