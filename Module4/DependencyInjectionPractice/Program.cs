using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IMessageService, EmailService>();
services.AddTransient<NotificationService>();
services.AddTransient<TransientService>();
services.AddSingleton<SingletonService>();
services.AddScoped<ScopedService>();

var serviceProvider = services.BuildServiceProvider();

var notificationService = serviceProvider.GetRequiredService<NotificationService>();

notificationService.SendNotification("Hello from Dependency Injection!");

var transient1 = serviceProvider.GetRequiredService<TransientService>();
var transient2 = serviceProvider.GetRequiredService<TransientService>();

Console.WriteLine($"Transient 1: {transient1.Id}");
Console.WriteLine($"Transient 2: {transient2.Id}");

var singleton1 = serviceProvider.GetRequiredService<SingletonService>();
var singleton2 = serviceProvider.GetRequiredService<SingletonService>();

Console.WriteLine($"Singleton 1: {singleton1.Id}");
Console.WriteLine($"Singleton 2: {singleton2.Id}");

using (var scope1 = serviceProvider.CreateScope())
{
    var scoped1 = scope1.ServiceProvider.GetRequiredService<ScopedService>();
    var scoped2 = scope1.ServiceProvider.GetRequiredService<ScopedService>();

    Console.WriteLine($"Scope 1 - Service 1: {scoped1.Id}");
    Console.WriteLine($"Scope 1 - Service 2: {scoped2.Id}");
}

using (var scope2 = serviceProvider.CreateScope())
{
    var scoped3 = scope2.ServiceProvider.GetRequiredService<ScopedService>();

    Console.WriteLine($"Scope 2 - Service 1: {scoped3.Id}");
}