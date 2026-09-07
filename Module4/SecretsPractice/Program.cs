using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

string? apiKey = configuration["ApiSettings:ApiKey"];
string? connectionString = configuration["DatabaseSettings:ConnectionString"];

if (string.IsNullOrEmpty(apiKey))
{
    Console.WriteLine("API Key was not found.");
}
else
{
    Console.WriteLine("API Key was found.");
}

if (string.IsNullOrEmpty(connectionString))
{
    Console.WriteLine("Connection String was not found.");
}
else
{
    Console.WriteLine("Connection String was found.");
}