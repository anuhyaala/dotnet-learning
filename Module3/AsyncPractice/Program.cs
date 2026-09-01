// using System;
// using System.Threading.Tasks;

// Console.WriteLine("Program started.");

// await DoWorkAsync();

// Console.WriteLine("Program finished.");

// static async Task DoWorkAsync()
// {
//     Console.WriteLine("Work started.");

//     await Task.Delay(3000);

//     Console.WriteLine("Work finished.");
// }



// using System;
// using System.Threading.Tasks;

// Console.WriteLine("Program started");
// string message = await GetMessageAsync();
// Console.WriteLine($"Message received: {message}");
// Console.WriteLine("Program finished");
// static async Task<string> GetMessageAsync()
// {
//     Console.WriteLine("Starting async work...");
//     await Task.Delay(3000);
//     return "Hello from asynchronous method!";
// }


// using System.Net.Http;
// using System.Text.Json;

// using HttpClient client = new HttpClient();

// string url = "https://v2.jokeapi.dev/joke/Programming?type=single&safe-mode";

// Console.WriteLine("Sending request...");

// string response = await client.GetStringAsync(url);

// Console.WriteLine("Response received:");
// Console.WriteLine(response);

// JokeResponse? jokeResponse =
//     JsonSerializer.Deserialize<JokeResponse>(response);

// Console.WriteLine();
// Console.WriteLine("Deserialized joke:");

// if (jokeResponse != null)
// {
//     Console.WriteLine(jokeResponse.Joke);
// }

// public class JokeResponse
// {
//     public string Joke { get; set; } = "";
// }



using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

await GetJokeAsync();

static async Task GetJokeAsync()
{
    using HttpClient client = new HttpClient();

    string url = "https://v2.jokeapi.dev/joke/Programming?type=single&safe-mode";

    try
    {
        Console.WriteLine("Sending request...");

        string response = await client.GetStringAsync(url);

        Console.WriteLine();
        Console.WriteLine("JSON response:");
        Console.WriteLine(response);

        JokeResponse? jokeResponse =
            JsonSerializer.Deserialize<JokeResponse>(response);

        if (jokeResponse != null)
        {
            Console.WriteLine();
            Console.WriteLine("Joke:");
            Console.WriteLine(jokeResponse.Joke);
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine("HTTP request failed.");
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (JsonException ex)
    {
        Console.WriteLine("JSON deserialization failed.");
        Console.WriteLine($"Error: {ex.Message}");
    }
}

public class JokeResponse
{
    [JsonPropertyName("joke")]
    public string Joke { get; set; } = "";
}