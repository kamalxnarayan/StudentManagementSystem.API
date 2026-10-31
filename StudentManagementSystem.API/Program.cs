
using StudentManagementSystem.API.Middleware;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Register controllers
builder.Services.AddControllers();

// Enable OpenAPI
builder.Services.AddOpenApi();

// Configure SQL Server database connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

// Enable OpenAPI in development
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Authorization middleware
app.UseAuthorization();

// Map API controllers
app.MapControllers();

app.Run();
