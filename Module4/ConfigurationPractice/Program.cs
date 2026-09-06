using Microsoft.Extensions.Configuration;

string environment =
    Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
    ?? "Production";

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddJsonFile(
        $"appsettings.{environment}.json",
        optional: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

string? appName = configuration["Settings:AppName"];
string? maxRetries = configuration["Settings:MaxRetries"];

Console.WriteLine($"Environment: {environment}");
Console.WriteLine($"App Name: {appName}");
Console.WriteLine($"Max Retries: {maxRetries}");