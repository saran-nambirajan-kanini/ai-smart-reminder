using AiSmartReminder.Application;
using AiSmartReminder.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Configuration validation
ValidateRequiredConfiguration(builder.Configuration);

// Register layer services
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

// Add framework services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

// Configure CORS
var allowedOrigins = builder.Configuration.GetSection("CorsSettings:AllowedOrigins").Get<string[]>() ?? [];
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapHealthChecks("/health");
app.MapControllers();

app.Run();

static void ValidateRequiredConfiguration(IConfiguration configuration)
{
    var requiredKeys = new[]
    {
        "ConnectionStrings:DefaultConnection",
        "JwtSettings:Secret",
        "JwtSettings:Issuer",
        "JwtSettings:Audience"
    };

    var missingKeys = requiredKeys
        .Where(key => string.IsNullOrWhiteSpace(configuration[key]))
        .ToList();

    if (missingKeys.Count > 0)
    {
        throw new InvalidOperationException(
            $"Missing required configuration keys: {string.Join(", ", missingKeys)}. " +
            "Ensure all required values are set in appsettings.json or environment variables.");
    }
}

/// <summary>
/// Partial class to expose Program for integration/architecture testing.
/// </summary>
public partial class Program { }

