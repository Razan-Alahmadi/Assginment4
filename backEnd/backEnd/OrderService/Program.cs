using Microsoft.EntityFrameworkCore;
using OrderService.Data; 


var builder = WebApplication.CreateBuilder(args);

// 1- Add services to the container.
builder.Services.AddControllers();

// 2- Configure MySQL database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


// 3- Swagger API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 4- Enable CORS to allow requests from Angular (running on localhost:4200)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
        policy.WithOrigins("http://localhost:4200")  // Allow Angular app from localhost:4200
              .AllowAnyMethod()                     // Allow all HTTP methods (GET, POST, etc.)
              .AllowAnyHeader());                   // Allow any headers
});


// 5-
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//-6
app.UseCors("AllowAngularApp");  // Apply the CORS policy to all requests
app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
app.UseAuthorization();
app.MapControllers(); // Map API controllers

// -7

app.Run();
