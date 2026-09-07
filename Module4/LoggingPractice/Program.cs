using Microsoft.Extensions.Logging;

using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
    builder.SetMinimumLevel(LogLevel.Trace);
});

ILogger logger = loggerFactory.CreateLogger("LoggingPractice");

logger.LogTrace("This is a trace message.");

logger.LogDebug("This is a debug message.");

logger.LogInformation("Application started successfully.");

logger.LogWarning("This is a warning message.");

logger.LogError("This is an error message.");

logger.LogCritical("This is a critical message.");

try
{
    int number = 10;
    int result = number / 0;
}
catch (Exception ex)
{
    logger.LogError(ex, "An exception occurred while performing the calculation.");
}

string userName = "Anuhya";
int orderId = 101;

logger.LogInformation(
    "User {UserName} created order {OrderId}",
    userName,
    orderId);