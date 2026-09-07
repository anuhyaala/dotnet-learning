using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var services = new ServiceCollection();

services.Configure<AppSettings>(
    configuration.GetSection("AppSettings"));

services.AddTransient<SettingsService>();

var serviceProvider = services.BuildServiceProvider();

var settingsService = serviceProvider.GetRequiredService<SettingsService>();

settingsService.DisplaySettings();