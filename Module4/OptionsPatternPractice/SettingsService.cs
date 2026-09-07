using Microsoft.Extensions.Options;

public class SettingsService
{
    private readonly IOptionsMonitor<AppSettings> _options;

    public SettingsService(IOptionsMonitor<AppSettings> options)
    {
        _options = options;
    }

    public void DisplaySettings()
    {
        AppSettings settings = _options.CurrentValue;

        Console.WriteLine($"App Name: {settings.AppName}");
        Console.WriteLine($"Max Retries: {settings.MaxRetries}");
    }
}